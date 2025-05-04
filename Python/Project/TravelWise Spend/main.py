from flask import Flask, render_template, request, redirect, url_for, flash, session, Response
import sqlite3
from werkzeug.security import generate_password_hash, check_password_hash
from datetime import datetime
from reportlab.lib import colors
from reportlab.lib.pagesizes import letter
from reportlab.platypus import SimpleDocTemplate, Table, TableStyle, Paragraph
from reportlab.lib.styles import getSampleStyleSheet
import io
import requests
import json

app = Flask(__name__)
app.secret_key = 'your-secret-key-here'

# Gemini API configuration
GEMINI_API_KEY = 'AIzaSyCo6_LE-0tjnjH2xh8UELFZ5uRQyYv18tE'
GEMINI_API_URL = 'https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent'

# Database initialization
def init_db():
    conn = sqlite3.connect('travelwise.db')
    c = conn.cursor()
    c.execute('''CREATE TABLE IF NOT EXISTS users
                 (id INTEGER PRIMARY KEY AUTOINCREMENT,
                  name TEXT NOT NULL,
                  email TEXT UNIQUE NOT NULL,
                  password TEXT NOT NULL,
                  phone TEXT NOT NULL)''')
    c.execute('''CREATE TABLE IF NOT EXISTS budget_plans
                 (id INTEGER PRIMARY KEY AUTOINCREMENT,
                  user_id INTEGER,
                  travel_place TEXT NOT NULL,
                  total_budget REAL NOT NULL,
                  date_from TEXT NOT NULL,
                  date_to TEXT NOT NULL,
                  total_days INTEGER NOT NULL,
                  daily_budget REAL NOT NULL,
                  FOREIGN KEY (user_id) REFERENCES users(id))''')
    c.execute('''CREATE TABLE IF NOT EXISTS daily_expenses
                 (id INTEGER PRIMARY KEY AUTOINCREMENT,
                  budget_id INTEGER,
                  category_name TEXT NOT NULL,
                  expense REAL NOT NULL,
                  date TEXT NOT NULL,
                  FOREIGN KEY (budget_id) REFERENCES budget_plans(id))''')
    conn.commit()
    conn.close()

# Login route
@app.route('/login', methods=['GET', 'POST'])
def login():
    if request.method == 'POST':
        email = request.form['email']
        password = request.form['password']

        conn = sqlite3.connect('travelwise.db')
        c = conn.cursor()
        c.execute('SELECT * FROM users WHERE email = ?', (email,))
        user = c.fetchone()
        conn.close()

        if user and check_password_hash(user[3], password):
            session['user_id'] = user[0]
            flash('Login successful!', 'success')
            return redirect(url_for('home'))
        else:
            flash('Invalid credentials', 'error')

    return render_template('login.html')

# New account route
@app.route('/new_account', methods=['GET', 'POST'])
def new_account():
    if request.method == 'POST':
        name = request.form['name']
        email = request.form['email']
        password = generate_password_hash(request.form['password'])
        phone = request.form['phone']

        try:
            conn = sqlite3.connect('travelwise.db')
            c = conn.cursor()
            c.execute('INSERT INTO users (name, email, password, phone) VALUES (?, ?, ?, ?)',
                      (name, email, password, phone))
            conn.commit()
            conn.close()
            flash('Account created successfully!', 'success')
            return redirect(url_for('login'))
        except sqlite3.IntegrityError:
            flash('Email already exists!', 'error')

    return render_template('new_account.html')

# Logout route
@app.route('/logout')
def logout():
    session.pop('user_id', None)
    flash('Logged out successfully!', 'success')
    return redirect(url_for('login'))

# Home route
@app.route('/')
def home():
    if 'user_id' not in session:
        return redirect(url_for('login'))

    conn = sqlite3.connect('travelwise.db')
    c = conn.cursor()
    c.execute('SELECT * FROM budget_plans WHERE user_id = ?', (session['user_id'],))
    budgets = c.fetchall()
    conn.close()
    return render_template('index.html', budgets=budgets)

# Create budget route
@app.route('/create_budget', methods=['GET', 'POST'])
def create_budget():
    if 'user_id' not in session:
        return redirect(url_for('login'))

    if request.method == 'POST':
        travel_place = request.form['travel_place']
        total_budget = float(request.form['total_budget'])
        date_from = request.form['date_from']
        date_to = request.form['date_to']

        start_date = datetime.strptime(date_from, '%Y-%m-%d')
        end_date = datetime.strptime(date_to, '%Y-%m-%d')
        total_days = (end_date - start_date).days + 1
        daily_budget = total_budget / total_days

        conn = sqlite3.connect('travelwise.db')
        c = conn.cursor()
        c.execute('''INSERT INTO budget_plans 
                    (user_id, travel_place, total_budget, date_from, date_to, total_days, daily_budget)
                    VALUES (?, ?, ?, ?, ?, ?, ?)''',
                  (session['user_id'], travel_place, total_budget, date_from, date_to, total_days, daily_budget))
        conn.commit()
        conn.close()
        flash('Budget created successfully!', 'success')
        return redirect(url_for('home'))

    return render_template('create_budget.html')

# Budget details route
@app.route('/budget/<int:budget_id>', methods=['GET', 'POST'])
def budget_details(budget_id):
    if 'user_id' not in session:
        return redirect(url_for('login'))

    conn = sqlite3.connect('travelwise.db')
    c = conn.cursor()

    c.execute('SELECT * FROM budget_plans WHERE id = ? AND user_id = ?', (budget_id, session['user_id']))
    budget = c.fetchone()

    if not budget:
        flash('Budget not found!', 'error')
        return redirect(url_for('home'))

    if request.method == 'POST':
        category_name = request.form['category_name']
        expense = float(request.form['expense'])
        date = request.form['date']

        c.execute('INSERT INTO daily_expenses (budget_id, category_name, expense, date) VALUES (?, ?, ?, ?)',
                  (budget_id, category_name, expense, date))
        conn.commit()

    c.execute('SELECT * FROM daily_expenses WHERE budget_id = ?', (budget_id,))
    expenses = c.fetchall()

    daily_totals = {}
    for expense in expenses:
        date = expense[4]
        if date not in daily_totals:
            daily_totals[date] = 0
        daily_totals[date] += expense[3]

    conn.close()
    return render_template('budget_details.html', budget=budget, expenses=expenses, daily_totals=daily_totals)

# Reports route
@app.route('/reports')
def reports():
    if 'user_id' not in session:
        return redirect(url_for('login'))

    conn = sqlite3.connect('travelwise.db')
    c = conn.cursor()

    c.execute('SELECT * FROM budget_plans WHERE user_id = ?', (session['user_id'],))
    budgets = c.fetchall()

    c.execute('''SELECT bp.travel_place, de.category_name, de.expense, de.date
                 FROM daily_expenses de
                 JOIN budget_plans bp ON de.budget_id = bp.id
                 WHERE bp.user_id = ?''', (session['user_id'],))
    expenses = c.fetchall()

    total_budget = sum(budget[3] for budget in budgets)
    total_expenses = sum(expense[2] for expense in expenses)
    remaining_budget = total_budget - total_expenses

    conn.close()

    return render_template('reports.html',
                           budgets=budgets,
                           expenses=expenses,
                           total_budget=total_budget,
                           total_expenses=total_expenses,
                           remaining_budget=remaining_budget)

# Download report route
@app.route('/download_report')
def download_report():
    if 'user_id' not in session:
        return redirect(url_for('login'))

    conn = sqlite3.connect('travelwise.db')
    c = conn.cursor()

    c.execute('SELECT * FROM budget_plans WHERE user_id = ?', (session['user_id'],))
    budgets = c.fetchall()

    c.execute('''SELECT bp.travel_place, de.category_name, de.expense, de.date
                 FROM daily_expenses de
                 JOIN budget_plans bp ON de.budget_id = bp.id
                 WHERE bp.user_id = ?''', (session['user_id'],))
    expenses = c.fetchall()

    total_budget = sum(budget[3] for budget in budgets)
    total_expenses = sum(expense[2] for expense in expenses)
    remaining_budget = total_budget - total_expenses

    conn.close()

    buffer = io.BytesIO()
    doc = SimpleDocTemplate(buffer, pagesize=letter, topMargin=50, bottomMargin=50)
    elements = []
    styles = getSampleStyleSheet()

    # Custom styles
    title_style = styles['Heading1']
    title_style.alignment = 1  # Center
    title_style.fontSize = 24
    title_style.textColor = colors.HexColor('#4CAF50')

    summary_style = styles['Heading2']
    summary_style.fontSize = 16
    summary_style.spaceAfter = 10

    # Title
    elements.append(Paragraph("TravelWise Spend Report", title_style))
    elements.append(Paragraph("<br/>Generated on: " + datetime.now().strftime("%Y-%m-%d %H:%M:%S"), styles['Normal']))
    elements.append(Paragraph("<br/><br/>", styles['Normal']))

    # Summary
    elements.append(Paragraph("Summary", summary_style))
    summary_data = [
        ["Total Budget:", f"Rs.{total_budget:.2f}"],
        ["Total Expenses:", f"Rs.{total_expenses:.2f}"],
        ["Remaining Budget:", f"Rs.{remaining_budget:.2f}" if remaining_budget >= 0 else f"Rs.{remaining_budget:.2f} (Over Budget)"]
    ]
    summary_table = Table(summary_data, colWidths=[200, 200])
    summary_table.setStyle(TableStyle([
        ('GRID', (0, 0), (-1, -1), 0.5, colors.grey),
        ('FONT', (0, 0), (-1, -1), 'Helvetica', 12),
        ('ALIGN', (1, 0), (-1, -1), 'RIGHT'),
        ('BACKGROUND', (0, 0), (0, -1), colors.HexColor('#f5f7fa')),
        ('TEXTCOLOR', (1, 2), (1, 2), colors.red if remaining_budget < 0 else colors.black)
    ]))
    elements.append(summary_table)
    elements.append(Paragraph("<br/><br/>", styles['Normal']))

    # Expenses
    elements.append(Paragraph("All Expenses", summary_style))
    expense_data = [["Travel Place", "Category", "Amount", "Date"]]
    for expense in expenses:
        expense_data.append([expense[0], expense[1], f"Rs.{expense[2]:.2f}", expense[3]])

    expense_table = Table(expense_data, colWidths=[150, 150, 100, 100])
    expense_table.setStyle(TableStyle([
        ('GRID', (0, 0), (-1, -1), 0.5, colors.grey),
        ('BACKGROUND', (0, 0), (-1, 0), colors.HexColor('#4CAF50')),
        ('TEXTCOLOR', (0, 0), (-1, 0), colors.white),
        ('FONT', (0, 0), (-1, 0), 'Helvetica-Bold', 12),
        ('FONT', (0, 1), (-1, -1), 'Helvetica', 11),
        ('ALIGN', (2, 0), (2, -1), 'RIGHT'),
        ('VALIGN', (0, 0), (-1, -1), 'MIDDLE'),
        ('BACKGROUND', (0, 1), (-1, -1), colors.HexColor('#fafafa') if len(expenses) > 0 else colors.white)
    ]))
    elements.append(expense_table)

    doc.build(elements)

    buffer.seek(0)
    return Response(
        buffer.getvalue(),
        mimetype='application/pdf',
        headers={'Content-Disposition': 'attachment;filename=travelwise_report.pdf'}
    )

# Graphs route
@app.route('/graphs')
def graphs():
    if 'user_id' not in session:
        return redirect(url_for('login'))

    conn = sqlite3.connect('travelwise.db')
    c = conn.cursor()

    c.execute('SELECT * FROM budget_plans WHERE user_id = ?', (session['user_id'],))
    budgets = c.fetchall()

    c.execute('''SELECT de.expense
                 FROM daily_expenses de
                 JOIN budget_plans bp ON de.budget_id = bp.id
                 WHERE bp.user_id = ?''', (session['user_id'],))
    expenses = c.fetchall()

    total_budget = sum(budget[3] for budget in budgets)
    total_expenses = sum(expense[0] for expense in expenses)
    remaining_budget = total_budget - total_expenses if total_budget > total_expenses else 0

    conn.close()

    return render_template('graphs.html',
                          total_budget=total_budget,
                          total_expenses=total_expenses,
                          remaining_budget=remaining_budget)

# AI Suggestion route
@app.route('/ai_suggestion', methods=['GET', 'POST'])
def ai_suggestion():
    if 'user_id' not in session:
        return redirect(url_for('login'))

    suggestions = []

    if request.method == 'POST':
        try:
            # Get form data
            state = request.form['state']
            destination_type = request.form['destination_type']
            place = request.form.get('place', '')
            date_from = request.form['date_from']
            date_to = request.form['date_to']
            total_budget = float(request.form['total_budget'])

            # Calculate total_days and daily_budget if not provided
            start_date = datetime.strptime(date_from, '%Y-%m-%d')
            end_date = datetime.strptime(date_to, '%Y-%m-%d')
            total_days = (end_date - start_date).days + 1
            daily_budget = total_budget / total_days

            # Override with form values if provided
            total_days = int(request.form.get('total_days', total_days))
            daily_budget = float(request.form.get('daily_budget', daily_budget))

            print(f"Form Data: state={state}, destination_type={destination_type}, place={place}, "
                  f"date_from={date_from}, date_to={date_to}, total_days={total_days}, "
                  f"total_budget={total_budget}, daily_budget={daily_budget}")

            if total_days <= 0 or total_budget <= 0 or daily_budget <= 0:
                flash('Total days and budget must be positive numbers.', 'error')
                return render_template('ai_suggestion.html', suggestions=suggestions)

            # Prepare prompt for Gemini API
            prompt = f"""
            I am planning a trip to {state}, India, and I am looking for a {destination_type}.
            {'I would prefer to visit ' + place + '.' if place else 'I do not have a specific place in mind.'}
            My travel dates are from {date_from} to {date_to}, which is {total_days} days.
            My total budget is Rs.{total_budget:.2f}, and my daily budget is Rs.{daily_budget:.2f}.
            Provide exactly the following suggestions within my budget, with no additional commentary, preamble, or extra sections:
            1. A specific place to visit in {state} that matches my destination type.
            2. A hotel to stay at in that place, including an estimated cost per night.
            3. A restaurant to eat at in that place, including an estimated cost per meal.
            4. A main tourist spot to visit in that place, including any entry fees or costs.
            Ensure all suggestions are budget-friendly and fit within my daily budget of Rs.{daily_budget:.2f}.
            Format the response as a numbered list (e.g., 1., 2., etc.) with optional bullet points (e.g., -) for details, and nothing else.
            """

            # Call Gemini API
            headers = {
                'Content-Type': 'application/json',
            }
            data = {
                "contents": [{
                    "parts": [{
                        "text": prompt
                    }]
                }]
            }
            try:
                print("Making Gemini API request...")
                response = requests.post(f"{GEMINI_API_URL}?key={GEMINI_API_KEY}", headers=headers, json=data)
                response.raise_for_status()
                result = response.json()
                print("API Response:", result)

                # Extract the generated text
                if 'candidates' in result and result['candidates']:
                    generated_text = result['candidates'][0]['content']['parts'][0]['text']
                    print("Generated Text:", generated_text)

                    # Parse the generated text into structured suggestions
                    lines = generated_text.split('\n')
                    current_suggestion = None
                    suggestions = []
                    found_first_numbered_section = False

                    for line in lines:
                        line = line.strip()
                        if not line:
                            continue
                        if line.startswith('1. ') or line.startswith('2. ') or line.startswith('3. ') or line.startswith('4. '):
                            found_first_numbered_section = True
                            if current_suggestion:
                                suggestions.append(current_suggestion)
                            title = ''
                            if line.startswith('1. '):
                                title = 'Suggested Place to Visit'
                            elif line.startswith('2. '):
                                title = 'Hotel to Stay'
                            elif line.startswith('3. '):
                                title = 'Restaurant to Eat At'
                            elif line.startswith('4. '):
                                title = 'Main Tourist Spot'
                            current_suggestion = {
                                'title': title,
                                'description': line[3:],
                                'list_items': []
                            }
                        elif found_first_numbered_section and current_suggestion and line.startswith('- '):
                            current_suggestion['list_items'].append(line[2:])
                        elif found_first_numbered_section and current_suggestion:
                            current_suggestion['description'] += ' ' + line

                    if current_suggestion:
                        suggestions.append(current_suggestion)

                    if not suggestions:
                        suggestions.append({
                            'title': 'Suggestions',
                            'description': generated_text,
                            'list_items': None
                        })
                else:
                    generated_text = "Sorry, I couldn't generate suggestions at this time."
                    suggestions.append({
                        'title': 'Error',
                        'description': generated_text,
                        'list_items': None
                    })
                    print("No candidates in response.")
            except requests.exceptions.RequestException as e:
                flash(f"Error generating suggestions: {str(e)}", 'error')
                suggestions.append({
                    'title': 'Error',
                    'description': 'Unable to generate suggestions at this time. Please try again later.',
                    'list_items': None
                })
                print(f"API Error: {str(e)}")

            print("Parsed Suggestions:", suggestions)

        except (KeyError, ValueError) as e:
            flash(f'Invalid form data: {str(e)}', 'error')
            print(f"Form Error: {str(e)}")

    return render_template('ai_suggestion.html', suggestions=suggestions)

if __name__ == '__main__':
    init_db()
    app.run(debug=True)