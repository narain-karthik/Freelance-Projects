from flask import Flask, render_template, request, redirect, url_for, flash, session, send_file
import sqlite3
from werkzeug.security import generate_password_hash, check_password_hash
import requests
import json
import markdown
from xhtml2pdf import pisa  # Using xhtml2pdf for PDF generation
import io

app = Flask(__name__)
app.secret_key = 'your-secret-key-here'

GEMINI_API_KEY = 'AIzaSyCo6_LE-0tjnjH2xh8UELFZ5uRQyYv18tE'
GEMINI_API_URL = 'https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent'

# Database initialization
def init_db():
    conn = sqlite3.connect('database.db')
    c = conn.cursor()
    c.execute('''CREATE TABLE IF NOT EXISTS users
                 (id INTEGER PRIMARY KEY AUTOINCREMENT,
                  name TEXT NOT NULL,
                  email TEXT UNIQUE NOT NULL,
                  password TEXT NOT NULL,
                  phone TEXT NOT NULL)''')
    c.execute('''CREATE TABLE IF NOT EXISTS workout_plans
                 (id INTEGER PRIMARY KEY AUTOINCREMENT,
                  user_id INTEGER,
                  current_weight REAL,
                  target_weight REAL,
                  height REAL,  -- Added height column
                  fitness_goals TEXT,
                  gender TEXT,
                  training_method TEXT,
                  workout_type TEXT,
                  strength_level TEXT,
                  dob TEXT,
                  plan TEXT,
                  FOREIGN KEY (user_id) REFERENCES users(id))''')
    conn.commit()
    conn.close()

def generate_diet_plan(user_data):
    headers = {
        'Content-Type': 'application/json',
    }

    # Base introduction for all plans
    intro = f"""Creating a personalized plan for {user_data['fitness_goals'].lower()} involves focusing on {'nutrition' if user_data['training_method'] == 'Meal plan only' else 'exercises' if user_data['training_method'] == 'Exercise routine only' else 'both nutrition and exercises'} to support your goals. Since you're a {user_data['strength_level'].lower()} and using {user_data['workout_type'].lower()}, the plan will be tailored to your needs. Your height of {user_data['height']} cm and current weight of {user_data['current_weight']} kg will be considered for recommendations. {'Nutrition will be tailored to support your goals.' if user_data['training_method'] in ['Meal plan only', 'Combined'] else ''}"""

    # Warm-up section (only for exercise or combined plans)
    warmup_section = ""
    if user_data['training_method'] in ['Exercise routine only', 'Combined']:
        warmup_section = """
### Warm-Up (5-10 minutes):
- Jumping Jacks: 2 minutes
- Arm Circles: 1 minute
- Leg Swings: 1 minute (30 seconds each leg)
- Bodyweight Squats: 1 minute
- Dynamic Stretching: 2-3 minutes (e.g., lunges with a twist, torso twists)
        """

    # Daily workout plans (only for exercise or combined plans)
    workout_plan = """
**Day 1: Upper Body Focus**
1. **Push-ups**: 3 sets of 8-12 reps
   - Start on your knees if regular push-ups are challenging.
2. **Incline Push-ups (hands on an elevated surface)**: 3 sets of 8-12 reps
3. **Tricep Dips (using a sturdy chair)**: 3 sets of 8-10 reps
4. **Pike Push-ups**: 3 sets of 5-10 reps
5. **Plank to Push-up**: 3 sets of 5-8 reps

**Core Finisher:**
- **Plank**: 3 sets of 30-60 seconds
- **Russian Twists**: 3 sets of 10-15 reps per side

---

**Day 2: Lower Body Focus**
1. **Bodyweight Squats**: 3 sets of 12-15 reps
2. **Lunges (alternating legs)**: 3 sets of 10-12 reps per leg
3. **Glute Bridges**: 3 sets of 12-15 reps
4. **Step-Ups (using a chair or sturdy platform)**: 3 sets of 10-12 reps per leg
5. **Wall Sit**: 3 sets of 30-60 seconds

**Core Finisher:**
- **Bicycle Crunches**: 3 sets of 15 reps per side
- **Leg Raises**: 3 sets of 10-12 reps

---

**Day 3: Full Body Focus**
1. **Burpees**: 3 sets of 6-10 reps
2. **Mountain Climbers**: 3 sets of 30 seconds
3. **Squat to Calf Raise**: 3 sets of 10-12 reps
4. **Single-Leg Deadlifts (bodyweight)**: 3 sets of 10 reps per leg
5. **Plank Shoulder Taps**: 3 sets of 10-12 reps per side

**Core Finisher:**
- **Side Plank**: 2 sets of 20-30 seconds per side
- **Flutter Kicks**: 3 sets of 15-20 reps

---

**Day 4: Upper Body Focus**
1. **Push-ups**: 3 sets of 8-12 reps
   - Progress to regular push-ups if possible.
2. **Incline Push-ups**: 3 sets of 8-12 reps
3. **Tricep Dips**: 3 sets of 8-10 reps
4. **Pike Push-ups**: 3 sets of 5-10 reps
5. **Plank to Push-up**: 3 sets of 5-8 reps

**Core Finisher:**
- **Plank**: 3 sets of 30-60 seconds
- **Russian Twists**: 3 sets of 10-15 reps per side

---

**Day 5: Lower Body Focus**
1. **Bodyweight Squats**: 3 sets of 12-15 reps
2. **Lunges (alternating legs)**: 3 sets of 10-12 reps per leg
3. **Glute Bridges**: 3 sets of 12-15 reps
4. **Step-Ups**: 3 sets of 10-12 reps per leg
5. **Wall Sit**: 3 sets of 30-60 seconds

**Core Finisher:**
- **Bicycle Crunches**: 3 sets of 15 reps per side
- **Leg Raises**: 3 sets of 10-12 reps

---

**Day 6: Active Recovery/Optional Cardio**
- Light jogging, brisk walking, cycling, or yoga for 20-30 minutes.
    """

    # Daily nutrition plans (only for meal plan or combined plans)
    nutrition_plan = f"""
**Day 1 Nutrition (for {user_data['fitness_goals']})**
- **Breakfast**: 3 egg omelette with spinach, 1 slice whole-grain toast, 1/2 avocado
- **Snack**: Greek yogurt (150g) with a handful of almonds
- **Lunch**: Grilled chicken breast (150g), quinoa (1 cup), steamed broccoli
- **Snack**: Protein shake (1 scoop whey protein, 1 banana, almond milk)
- **Dinner**: Baked salmon (150g), sweet potato (1 medium), mixed green salad with olive oil dressing

---

**Day 2 Nutrition (for {user_data['fitness_goals']})**
- **Breakfast**: Oatmeal (1/2 cup oats) with berries, 1 tbsp chia seeds, 1 boiled egg
- **Snack**: Apple slices with 1 tbsp peanut butter
- **Lunch**: Turkey breast (150g), brown rice (1 cup), steamed asparagus
- **Snack**: Cottage cheese (100g) with pineapple chunks
- **Dinner**: Grilled tofu (150g), roasted vegetables (zucchini, bell peppers), 1/2 cup couscous

---

**Day 3 Nutrition (for {user_data['fitness_goals']})**
- **Breakfast**: Smoothie (spinach, 1 banana, 1 scoop protein powder, almond milk)
- **Snack**: Handful of mixed nuts (almonds, walnuts)
- **Lunch**: Grilled shrimp (150g), quinoa (1 cup), sautéed kale
- **Snack**: 1 boiled egg, 1 orange
- **Dinner**: Lean beef (150g), roasted sweet potato, steamed green beans

---

**Day 4 Nutrition (for {user_data['fitness_goals']})**
- **Breakfast**: Whole-grain toast with 1/2 avocado, 2 poached eggs
- **Snack**: Protein bar (low sugar)
- **Lunch**: Grilled chicken salad (150g chicken, mixed greens, cherry tomatoes, olive oil dressing)
- **Snack**: Greek yogurt (150g) with a handful of blueberries
- **Dinner**: Baked cod (150g), roasted Brussels sprouts, 1/2 cup wild rice

---

**Day 5 Nutrition (for {user_data['fitness_goals']})**
- **Breakfast**: Scrambled eggs (3 eggs) with diced bell peppers, 1 slice whole-grain toast
- **Snack**: Handful of cashews
- **Lunch**: Grilled turkey (150g), roasted sweet potato, steamed spinach
- **Snack**: Protein shake (1 scoop whey protein, 1/2 cup berries, water)
- **Dinner**: Grilled chicken (150g), quinoa (1 cup), mixed vegetable stir-fry

---

**Day 6 Nutrition (for {user_data['fitness_goals']})**
- **Breakfast**: Smoothie (kale, 1 apple, 1 scoop protein powder, almond milk)
- **Snack**: 1 boiled egg, 1 pear
- **Lunch**: Tuna salad (150g tuna, mixed greens, cucumber, olive oil dressing)
- **Snack**: Handful of almonds
- **Dinner**: Baked salmon (150g), roasted vegetables (carrots, zucchini), 1/2 cup brown rice
    """

    # Cool-down section (only for exercise or combined plans)
    cooldown_section = ""
    if user_data['training_method'] in ['Exercise routine only', 'Combined']:
        cooldown_section = """
### Cool Down (5-10 minutes):
- Static stretching focusing on major muscle groups (hold each stretch for 15-30 seconds).
        """

    # Nutrition tips (only for meal plan or combined plans)
    nutrition_tips_section = ""
    if user_data['training_method'] in ['Meal plan only', 'Combined']:
        nutrition_tips_section = f"""
### General Nutrition Tips for {user_data['fitness_goals']}
1. **Protein Intake**: Aim for a protein-rich meal after workouts (e.g., chicken, fish, legumes, tofu).
2. **Balanced Meals**: Include healthy fats (avocado, nuts, olive oil) and complex carbohydrates (brown rice, quinoa, sweet potatoes).
3. **Hydration**: Drink plenty of water throughout the day; aim for at least 8 cups.
4. **Meal Timing**: Consider smaller meals/snacks every 3-4 hours to support muscle recovery and growth (or fat loss, depending on the goal).
        """

    # Progression and note sections (only for exercise or combined plans)
    progression_section = ""
    note_section = ""
    if user_data['training_method'] in ['Exercise routine only', 'Combined']:
        progression_section = """
### Progression
- As you get stronger, increase the number of reps, sets, or duration of exercises. You can also slow down the tempo of your movements for added resistance.
        """
        note_section = """
### Note
Always listen to your body, and if you feel pain (not to be confused with discomfort from exercise), modify the exercise or take a break. Consult with a healthcare professional before starting any new workout program, especially if you have existing health concerns.
        """

    # Construct the daily plan based on training_method
    daily_plan_heading = "### Daily Plan\n"
    daily_plan_content = ""

    if user_data['training_method'] == 'Meal plan only':
        daily_plan_content = nutrition_plan
    elif user_data['training_method'] == 'Exercise routine only':
        daily_plan_content = workout_plan
    else:  # Combined
        daily_plan_heading = "### Daily Workout and Nutrition Plan\n"
        for day in range(1, 7):
            workout_day = workout_plan.split(f"**Day {day}:")[1].split("---")[0].strip() if f"**Day {day}:" in workout_plan else ""
            nutrition_day = nutrition_plan.split(f"**Day {day} Nutrition")[1].split("---")[0].strip() if f"**Day {day} Nutrition" in nutrition_plan else ""
            daily_plan_content += f"""
**Day {day}:**
{workout_day}

**Day {day} Nutrition (for {user_data['fitness_goals']})**
{nutrition_day}

---
            """

    # Construct the full prompt
    prompt = f"""
Create a personalized 6-day plan for a person with the following details:
Current Weight: {user_data['current_weight']} kg
Target Weight: {user_data['target_weight']} kg
Height: {user_data['height']} cm
Fitness Goals: {user_data['fitness_goals']}
Gender: {user_data['gender']}
Training Method: {user_data['training_method']}
Workout Type: {user_data['workout_type']}
Strength Level: {user_data['strength_level']}
Date of Birth: {user_data['dob']}

Format the response exactly as follows using Markdown syntax:

{intro}

### Personalized 6-Day Plan

**Frequency:**
- {'5 workout days and 1 active recovery day per week' if user_data['training_method'] in ['Exercise routine only', 'Combined'] else '6 days of nutrition planning per week'}

{warmup_section}

---

{daily_plan_heading}
{daily_plan_content}

{cooldown_section}

---

{nutrition_tips_section}

{progression_section}

{note_section}

Ensure the response follows this exact structure and uses Markdown formatting for headings, bold text, and lists. Adjust the nutrition plan based on the fitness goal (e.g., higher calories for muscle gain, calorie deficit for weight loss).
    """

    data = {
        "contents": [{
            "parts": [{"text": prompt}]
        }]
    }

    try:
        response = requests.post(
            f"{GEMINI_API_URL}?key={GEMINI_API_KEY}",
            headers=headers,
            json=data
        )
        response.raise_for_status()
        result = response.json()
        return result['candidates'][0]['content']['parts'][0]['text']
    except Exception as e:
        return f"Error generating plan: {str(e)}"

@app.route('/')
def index():
    if 'user_id' in session:
        return redirect(url_for('home'))
    return redirect(url_for('login'))

@app.route('/login', methods=['GET', 'POST'])
def login():
    if request.method == 'POST':
        email = request.form['email']
        password = request.form['password']

        conn = sqlite3.connect('database.db')
        c = conn.cursor()
        c.execute('SELECT * FROM users WHERE email = ?', (email,))
        user = c.fetchone()
        conn.close()

        if user and check_password_hash(user[3], password):
            session['user_id'] = user[0]
            session['user_name'] = user[1]
            return redirect(url_for('home'))
        else:
            flash('Invalid email or password')

    return render_template('login.html')

@app.route('/register', methods=['GET', 'POST'])
def register():
    if request.method == 'POST':
        name = request.form['name']
        email = request.form['email']
        password = generate_password_hash(request.form['password'])
        phone = request.form['phone']

        try:
            conn = sqlite3.connect('database.db')
            c = conn.cursor()
            c.execute('INSERT INTO users (name, email, password, phone) VALUES (?, ?, ?, ?)',
                      (name, email, password, phone))
            conn.commit()
            conn.close()
            flash('Account created successfully! Please login.')
            return redirect(url_for('login'))
        except sqlite3.IntegrityError:
            flash('Email already exists!')

    return render_template('register.html')

@app.route('/home', methods=['GET', 'POST'])
def home():
    if 'user_id' not in session:
        return redirect(url_for('login'))

    if request.method == 'POST':
        user_data = {
            'current_weight': request.form['current_weight'],
            'target_weight': request.form['target_weight'],
            'height': request.form['height'],  # Added height
            'fitness_goals': request.form['fitness_goals'],
            'gender': request.form['gender'],
            'training_method': request.form['training_method'],
            'workout_type': request.form['workout_type'],
            'strength_level': request.form['strength_level'],
            'dob': request.form['dob']
        }

        # Generate plan using Gemini AI
        plan = generate_diet_plan(user_data)

        # Convert Markdown to HTML for display
        plan_html = markdown.markdown(plan)

        # Save to database
        conn = sqlite3.connect('database.db')
        c = conn.cursor()
        c.execute('''INSERT INTO workout_plans 
                    (user_id, current_weight, target_weight, height, fitness_goals, gender, 
                     training_method, workout_type, strength_level, dob, plan)
                    VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)''',
                  (session['user_id'],
                   user_data['current_weight'],
                   user_data['target_weight'],
                   user_data['height'],  # Added height
                   user_data['fitness_goals'],
                   user_data['gender'],
                   user_data['training_method'],
                   user_data['workout_type'],
                   user_data['strength_level'],
                   user_data['dob'],
                   plan))
        conn.commit()
        conn.close()

        return render_template('home.html', name=session['user_name'], plan=plan_html, raw_plan=plan)

    # Display the most recent plan if it exists
    conn = sqlite3.connect('database.db')
    c = conn.cursor()
    c.execute('SELECT plan FROM workout_plans WHERE user_id = ? ORDER BY id DESC LIMIT 1',
              (session['user_id'],))
    plan = c.fetchone()
    conn.close()

    plan_html = markdown.markdown(plan[0]) if plan else None
    raw_plan = plan[0] if plan else None

    return render_template('home.html',
                           name=session['user_name'],
                           plan=plan_html,
                           raw_plan=raw_plan)

@app.route('/download_pdf')
def download_pdf():
    if 'user_id' not in session:
        return redirect(url_for('login'))

    # Fetch the most recent plan
    conn = sqlite3.connect('database.db')
    c = conn.cursor()
    c.execute('SELECT plan FROM workout_plans WHERE user_id = ? ORDER BY id DESC LIMIT 1',
              (session['user_id'],))
    plan = c.fetchone()
    conn.close()

    if not plan:
        flash('No plan available to download.')
        return redirect(url_for('home'))

    # Convert Markdown to HTML
    plan_html = markdown.markdown(plan[0])

    # Render the PDF template with the plan content
    pdf_html = render_template('pdf_template.html', plan=plan_html)

    # Convert HTML to PDF using xhtml2pdf
    pdf_file = io.BytesIO()
    pisa_status = pisa.CreatePDF(pdf_html, dest=pdf_file, path='static/')

    # Check if PDF generation was successful
    if pisa_status.err:
        flash('Error generating PDF.')
        return redirect(url_for('home'))

    pdf_file.seek(0)

    return send_file(
        pdf_file,
        as_attachment=True,
        download_name='diet_plan.pdf',
        mimetype='application/pdf'
    )

@app.route('/logout')
def logout():
    session.pop('user_id', None)
    session.pop('user_name', None)
    return redirect(url_for('login'))

if __name__ == '__main__':
    init_db()
    app.run(debug=True)