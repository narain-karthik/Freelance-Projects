from flask import Flask, render_template, request, redirect, session, flash, url_for, send_file, send_from_directory, \
    jsonify
import pymysql
import pymysql.cursors
import pandas as pd
from io import BytesIO
import os
import uuid
from openpyxl.utils import get_column_letter
from reportlab.pdfgen import canvas

app = Flask(__name__)
app.secret_key = 'your_secret_key'

# MySQL Configuration
app.config['MYSQL_HOST'] = 'localhost'
app.config['MYSQL_USER'] = 'root'
app.config['MYSQL_PASSWORD'] = ''  # Update with your MySQL password if required
app.config['MYSQL_DB'] = 'Counseling'
app.config['MYSQL_CHARSET'] = 'utf8'  # Use utf8 instead of utf8mb4
app.config['MYSQL_COLLATION'] = 'utf8_unicode_ci'  # Use utf8_unicode_ci collation

# Function to get MySQL connection
def get_db_connection():
    connection = pymysql.connect(host=app.config['MYSQL_HOST'],
                                  user=app.config['MYSQL_USER'],
                                  password=app.config['MYSQL_PASSWORD'],
                                  database=app.config['MYSQL_DB'],
                                  charset=app.config['MYSQL_CHARSET'],
                                  cursorclass=pymysql.cursors.DictCursor)
    return connection

mydb = pymysql.connect(
    host="localhost",
    user="root",
    password="",
    database="counseling",
    charset="utf8"  # Change this line to use 'utf8' instead of 'utf8mb4'
)
mycursor = mydb.cursor()

# Define the upload and download folders
UPLOAD_FOLDER = 'uploads'
DOWNLOAD_FOLDER = 'downloads'
app.config['UPLOAD_FOLDER'] = UPLOAD_FOLDER
app.config['DOWNLOAD_FOLDER'] = DOWNLOAD_FOLDER

# Ensure the upload and download folders exist
os.makedirs(UPLOAD_FOLDER, exist_ok=True)
os.makedirs(DOWNLOAD_FOLDER, exist_ok=True)





# Create the table (run this once to set up your database)
try:
    mycursor.execute("""
        CREATE TABLE IF NOT EXISTS applications (
            application_no VARCHAR(255) PRIMARY KEY,
            name VARCHAR(255) NOT NULL,
            gender VARCHAR(255),
            community VARCHAR(255),
            email VARCHAR(255) NOT NULL,
            branch_choice VARCHAR(255),
            ug_college_studied VARCHAR(255),
            degree VARCHAR(255),
            branch_of_study VARCHAR(255),
            university_name VARCHAR(255),
            university_reg_number VARCHAR(255),
            exam_pattern VARCHAR(255),
            exam_assessment_method VARCHAR(255),
            semester1_Part1_maxMark INT, semester1_Part1_Obtained INT,
            semester1_Part2_maxMark INT, semester1_Part2_Obtained INT,
            semester1_Part3_maxMark INT, semester1_Part3_Obtained INT,
            semester1_Part4_maxMark INT, semester1_Part4_Obtained INT,
            semester2_Part1_maxMark INT, semester2_Part1_Obtained INT,
            semester2_Part2_maxMark INT, semester2_Part2_Obtained INT,
            semester2_Part3_maxMark INT, semester2_Part3_Obtained INT,
            semester2_Part4_maxMark INT, semester2_Part4_Obtained INT,
            semester3_Part1_maxMark INT, semester3_Part1_Obtained INT,
            semester3_Part2_maxMark INT, semester3_Part2_Obtained INT,
            semester3_Part3_maxMark INT, semester3_Part3_Obtained INT,
            semester3_Part4_maxMark INT, semester3_Part4_Obtained INT,
            semester4_Part1_maxMark INT, semester4_Part1_Obtained INT,
            semester4_Part2_maxMark INT, semester4_Part2_Obtained INT,
            semester4_Part3_maxMark INT, semester4_Part3_Obtained INT,
            semester4_Part4_maxMark INT, semester4_Part4_Obtained INT,
            semester5_Part1_maxMark INT, semester5_Part1_Obtained INT,
            semester5_Part2_maxMark INT, semester5_Part2_Obtained INT,
            semester5_Part3_maxMark INT, semester5_Part3_Obtained INT,
            semester5_Part4_maxMark INT, semester5_Part4_Obtained INT,
            semester6_Part1_maxMark INT, semester6_Part1_Obtained INT,
            semester6_Part2_maxMark INT, semester6_Part2_Obtained INT,
            semester6_Part3_maxMark INT, semester6_Part3_Obtained INT,
            semester6_Part4_maxMark INT, semester6_Part4_Obtained INT,
            year1_Part1_maxMark INT, year1_Part1_Obtained INT,
            year1_Part2_maxMark INT, year1_Part2_Obtained INT,
            year1_Part3_maxMark INT, year1_Part3_Obtained INT,
            year1_Part4_maxMark INT, year1_Part4_Obtained INT,
            year2_Part1_maxMark INT, year2_Part1_Obtained INT,
            year2_Part2_maxMark INT, year2_Part2_Obtained INT,
            year2_Part3_maxMark INT, year2_Part3_Obtained INT,
            year2_Part4_maxMark INT, year2_Part4_Obtained INT,
            year3_Part1_maxMark INT, year3_Part1_Obtained INT,
            year3_Part2_maxMark INT, year3_Part2_Obtained INT,
            year3_Part3_maxMark INT, year3_Part3_Obtained INT,
            year3_Part4_maxMark INT, year3_Part4_Obtained INT,
            semester1_CGPA_Max DECIMAL(3, 2), semester1_CGPA_Obtained DECIMAL(3, 2),
            semester2_CGPA_Max DECIMAL(3, 2), semester2_CGPA_Obtained DECIMAL(3, 2),
            semester3_CGPA_Max DECIMAL(3, 2), semester3_CGPA_Obtained DECIMAL(3, 2),
            semester4_CGPA_Max DECIMAL(3, 2), semester4_CGPA_Obtained DECIMAL(3, 2),
            semester5_CGPA_Max DECIMAL(3, 2), semester5_CGPA_Obtained DECIMAL(3, 2),
            semester6_CGPA_Max DECIMAL(3, 2), semester6_CGPA_Obtained DECIMAL(3, 2),
            year1_CGPA_Max DECIMAL(3, 2), year1_CGPA_Obtained DECIMAL(3, 2),
            year2_CGPA_Max DECIMAL(3, 2), year2_CGPA_Obtained DECIMAL(3, 2),
            year3_CGPA_Max DECIMAL(3, 2), year3_CGPA_Obtained DECIMAL(3, 2)
        )
    """)
    mydb.commit()
except pymysql.MySQLError as err:
    print(f"Error creating table: {err}")
    exit()

@app.route('/manage_users')
def manage_users():
    if 'loggedin' not in session or session['role'] != 'admin':
        return redirect('/login')  # Redirect unauthorized users

    try:
        connection = get_db_connection()
        with connection.cursor() as cursor:
            cursor.execute("SELECT id, full_name, email, username, password, role FROM users")
            users = cursor.fetchall()
    except pymysql.MySQLError as e:
        flash(f"Error fetching users: {e}", "error")
        users = []
    finally:
        connection.close()

    return render_template('manage_users.html', users=users)


@app.route('/delete_user/<int:user_id>')
def delete_user(user_id):
    if 'loggedin' not in session or session['role'] != 'admin':
        return redirect('/login')

    try:
        connection = get_db_connection()
        with connection.cursor() as cursor:
            cursor.execute("DELETE FROM users WHERE id = %s", (user_id,))
        connection.commit()
    except pymysql.MySQLError as e:
        flash(f"Error deleting user: {e}", "error")
    finally:
        connection.close()

    return redirect('/manage_users')

# Default route that redirects to /login
@app.route('/')
def index():
    return redirect('/login')

# Login route
@app.route('/login', methods=['GET', 'POST'])
def login():
    if request.method == 'POST':
        username = request.form['username']
        password = request.form['password']
        role = request.form['role']

        connection = get_db_connection()
        cursor = connection.cursor()
        cursor.execute('SELECT * FROM users WHERE username = %s AND password = %s AND role = %s',
                       (username, password, role))
        user = cursor.fetchone()
        connection.close()

        if user:
            session['loggedin'] = True
            session['username'] = user['username']
            session['role'] = user['role']

            if session['role'] == 'admin':
                return redirect('/admin_home')
            else:
                return redirect('/student_home')
        else:
            return 'Invalid Credentials!'
    return render_template('login.html')

# Register route
@app.route('/register', methods=['GET', 'POST'])
def register():
    if request.method == 'POST':
        full_name = request.form['full_name']
        email = request.form['email']
        username = request.form['username']
        password = request.form['password']
        role = request.form['role']

        connection = get_db_connection()
        cursor = connection.cursor()
        cursor.execute('INSERT INTO users (full_name, email, username, password, role) VALUES (%s, %s, %s, %s, %s)',
                       (full_name, email, username, password, role))
        connection.commit()
        connection.close()
        return redirect('/login')
    return render_template('register.html')

# Admin Home route
@app.route('/admin_home', methods=['GET', 'POST'])
def admin_home():
    if 'loggedin' not in session or session['role'] != 'admin':
        return redirect('/login')

    if request.method == 'POST':
        if 'file' not in request.files:
            return "NO FILE UPLOADED!", 400

        file = request.files['file']
        if file.filename == '':
            return "NO FILE SELECTED!", 400

        file_extension = os.path.splitext(file.filename)[1]
        unique_filename = f"{uuid.uuid4().hex}{file_extension}"
        file_path = os.path.join(app.config['UPLOAD_FOLDER'], unique_filename)
        file.save(file_path)

        try:
            output_file_name, selected_html, waiting_html, rejected_html = process_file(file_path)
            if output_file_name.startswith("ERROR"):
                return output_file_name, 400
            # Store the output file path in session
            session['last_processed_file'] = output_file_name
        except Exception as e:
            return f"ERROR PROCESSING FILE: {str(e)}", 500

        # Redirect to the report page instead of rendering result.html
        return redirect(url_for('report'))

    return render_template('admin_home.html', username=session['username'])

def process_file(file_path):
    df = pd.read_excel(file_path)

    # Convert column names to uppercase
    df.columns = df.columns.str.strip().str.upper()

    # Compute Part-wise Averages
    for part in range(1, 5):
        obtained_cols = [col for col in df.columns if f"PART{part}_OBTAINED" in col]
        max_cols = [col for col in df.columns if f"PART{part}_MAXMARK" in col]
        if obtained_cols and max_cols:
            df[f"PART{part}_AVG"] = (df[obtained_cols].sum(axis=1) / df[max_cols].sum(axis=1)) * 100

    # Compute CGPA Performance for Year 1, Year 2, and Year 3
    for year in range(1, 4):
        max_col = f"YEAR{year}_CGPA_MAX"
        obtained_col = f"YEAR{year}_CGPA_OBTAINED"
        if max_col in df.columns and obtained_col in df.columns:
            df[f"YEAR{year}_CGPA_PERFORMANCE"] = (df[obtained_col] / df[max_col]) * 100

    # Rank students based on PART3_AVG
    if "PART3_AVG" not in df.columns:
        return "ERROR: MISSING 'PART3_AVG' COLUMN AFTER COMPUTATION."
    df = df.sort_values(by="PART3_AVG", ascending=False).reset_index(drop=True)
    df["RANK"] = df.index + 1

    # Community-based Selection Process
    TOTAL_STUDENTS = 35
    WAITING_LIST_SIZE = 5
    COMMUNITY_QUOTA = {
        "OC": round(TOTAL_STUDENTS * 31 / 100),
        "SC": round(TOTAL_STUDENTS * 15 / 100),
        "SCA": round(TOTAL_STUDENTS * 3 / 100),
        "ST": round(TOTAL_STUDENTS * 1 / 100),
        "BC": round(TOTAL_STUDENTS * 26.5 / 100),
        "BCM": round(TOTAL_STUDENTS * 3.5 / 100),
        "MBC": round(TOTAL_STUDENTS * 20 / 100)
    }
    COMMUNITY_QUOTA = {k: max(1, v) for k, v in COMMUNITY_QUOTA.items()}  # Ensure minimum quota

    selected_students = pd.DataFrame()
    unmet_quotas = []

    # Check required columns
    if "COMMUNITY" not in df.columns or "APPLICATION_NO" not in df.columns:
        return "ERROR: MISSING 'COMMUNITY' OR 'APPLICATION_NO' COLUMN."

    # Assign students based on community quota
    for community, quota in COMMUNITY_QUOTA.items():
        community_students = df[df["COMMUNITY"] == community]
        if len(community_students) < quota:
            unmet_quotas.append((community, quota - len(community_students)))
            quota = len(community_students)
        selected_students = pd.concat([selected_students, community_students.head(quota)], ignore_index=True)

    # Handle unmet quotas by reallocating
    remaining_quota_to_allocate = sum(q[1] for q in unmet_quotas)
    available_communities = df[~df['COMMUNITY'].isin([q[0] for q in unmet_quotas])]
    selected_application_numbers = selected_students["APPLICATION_NO"].tolist()
    available_communities = available_communities[
        ~available_communities["APPLICATION_NO"].isin(selected_application_numbers)]

    if remaining_quota_to_allocate > 0:
        remaining_students = available_communities.head(remaining_quota_to_allocate)
        selected_students = pd.concat([selected_students, remaining_students], ignore_index=True)

    # Sort selected students by rank and limit to 35
    selected_students = selected_students.sort_values(by="RANK").head(TOTAL_STUDENTS).reset_index(drop=True)

    # Waiting List: Next 5 students after selected (rank 36-40)
    remaining_students = df[~df["APPLICATION_NO"].isin(selected_students["APPLICATION_NO"])]
    waiting_list = remaining_students.sort_values(by="RANK").head(WAITING_LIST_SIZE).reset_index(drop=True)

    # Rejected List: All remaining students after selected and waiting list
    rejected_list = remaining_students[~remaining_students["APPLICATION_NO"].isin(waiting_list["APPLICATION_NO"])].reset_index(drop=True)

    # Define required columns for display
    required_columns = [
        "APPLICATION_NO", "NAME", "GENDER", "COMMUNITY", "EMAIL", "BRANCH_CHOICE",
        "UG_COLLEGE_STUDIED", "DEGREE", "BRANCH_OF_STUDY", "UNIVERSITY_NAME", "UNIVERSITY_REG_NUMBER",
        "PART1_AVG", "PART2_AVG", "PART3_AVG", "PART4_AVG",
        "YEAR1_CGPA_PERFORMANCE", "YEAR2_CGPA_PERFORMANCE", "YEAR3_CGPA_PERFORMANCE", "RANK"
    ]

    # Prepare data for display
    selected_students_display = selected_students[required_columns]
    waiting_list_display = waiting_list[required_columns]
    rejected_list_display = rejected_list[required_columns]

    # Convert to HTML for rendering
    selected_students_html = selected_students_display.to_html(index=False)
    waiting_list_html = waiting_list_display.to_html(index=False)
    rejected_list_html = rejected_list_display.to_html(index=False)

    # Save all lists to Excel with separate sheets
    output_file_name = f"FINAL_SELECTION_{uuid.uuid4().hex}.xlsx"
    output_file_path = os.path.join(app.config['DOWNLOAD_FOLDER'], output_file_name)
    with pd.ExcelWriter(output_file_path, engine='openpyxl') as writer:
        selected_students.to_excel(writer, sheet_name="Selected Students", index=False)
        waiting_list.to_excel(writer, sheet_name="Waiting List", index=False)
        rejected_list.to_excel(writer, sheet_name="Rejected List", index=False)

    return (output_file_name, selected_students_html, waiting_list_html, rejected_list_html)



@app.route('/download/<filename>')
def download_file(filename):
    file_path = os.path.join(app.config['DOWNLOAD_FOLDER'], filename)
    if not os.path.exists(file_path):
        return f"FILE {filename} NOT FOUND!", 404
    return send_from_directory(app.config['DOWNLOAD_FOLDER'], filename, as_attachment=True)


@app.route('/download/<filename>')
def download_page(filename):
    if 'loggedin' not in session or session['role'] != 'admin':
        return redirect('/login')  # Redirect unauthorized users

    download_link = url_for('download_file', filename=filename)
    return render_template('download.html', download_link=download_link)


# Student Home route
@app.route('/student_home', methods=['GET', 'POST'])
def student_home():
    # Ensure user is logged in and is a student
    if 'loggedin' not in session or session['role'] != 'student':
        return redirect(url_for('login'))  # Redirect to log in if unauthorized

    if request.method == "POST":
        try:
            # Get form data safely
            data = {
                "application_no": request.form.get("application_no"),
                "name": request.form.get("name"),
                "gender": request.form.get("gender"),
                "community": request.form.get("community"),
                "email": request.form.get("email"),
                "branch_choice": request.form.get("branch_choice"),
                "ug_college_studied": request.form.get("ug_college_studied"),
                "degree": request.form.get("degree"),
                "branch_of_study": request.form.get("branch_of_study"),
                "university_name": request.form.get("university_name"),
                "university_reg_number": request.form.get("university_reg_number"),
                "exam_pattern": request.form.get("exam_pattern"),
                "exam_assessment_method": request.form.get("exam_assessment_method")
            }

            # Add semester and year marks dynamically
            for i in range(1, 7):  # Semester loop
                for j in range(1, 5):  # Part loop
                    data[f"semester{i}_Part{j}_maxMark"] = request.form.get(f"semester{i}_Part{j}_maxMark")
                    data[f"semester{i}_Part{j}_Obtained"] = request.form.get(f"semester{i}_Part{j}_Obtained")

            for i in range(1, 4):  # Year loop
                for j in range(1, 5):  # Part loop
                    data[f"year{i}_Part{j}_maxMark"] = request.form.get(f"year{i}_Part{j}_maxMark")
                    data[f"year{i}_Part{j}_Obtained"] = request.form.get(f"year{i}_Part{j}_Obtained")

            # Add CGPA data dynamically
            for i in range(1, 7):  # Semester CGPA
                data[f"semester{i}_CGPA_Max"] = request.form.get(f"semester{i}_CGPA_Max")
                data[f"semester{i}_CGPA_Obtained"] = request.form.get(f"semester{i}_CGPA_Obtained")

            for i in range(1, 4):  # Year CGPA
                data[f"year{i}_CGPA_Max"] = request.form.get(f"year{i}_CGPA_Max")
                data[f"year{i}_CGPA_Obtained"] = request.form.get(f"year{i}_CGPA_Obtained")

            # Construct the SQL query dynamically
            columns = ", ".join(data.keys())
            placeholders = ", ".join(["%s"] * len(data))
            sql = f"INSERT INTO applications ({columns}) VALUES ({placeholders})"

            # Clean None values
            values = [value if value is not None else None for value in data.values()]

            # Execute the query
            mycursor.execute(sql, values)
            mydb.commit()

            flash("Application submitted successfully!", "success")
            return redirect(url_for("student_home"))

        except pymysql.MySQLError as err:
            mydb.rollback()
            flash(f"Database Error: {err}", "error")
        except Exception as e:
            flash(f"An unexpected error occurred: {e}", "error")

    # Render student home with session username
    return render_template("student_home.html", username=session['username'])

# Route to export data to Excel
@app.route("/export_excel")
def export_excel():
    import openpyxl
    from io import BytesIO
    from flask import send_file

    # Fetch data from the database
    mycursor = mydb.cursor()  # Create a cursor object
    mycursor.execute("SELECT * FROM `applications` WHERE 1")
    rows = mycursor.fetchall()

    # Debugging: Print the fetched rows
    print(f"Fetched {len(rows)} rows from the database.")

    if not rows:
        return "No data available to export.", 404  # Return an error if no data

    # Create a workbook and sheet
    wb = openpyxl.Workbook()
    sheet = wb.active
    sheet.title = "Applications"

    # Column headers
    headers = [desc[0] for desc in mycursor.description]  # Fetch column names
    sheet.append(headers)

    # Add data rows
    for row in rows:
        sheet.append([str(item) if item is not None else "" for item in row])  # Convert None to empty string

    # Save the workbook to a BytesIO object
    output = BytesIO()
    wb.save(output)
    output.seek(0)

    # Close cursor
    mycursor.close()

    # Return the file for download
    return send_file(output, as_attachment=True, download_name="applications.xlsx")

# View All Applications
@app.route('/manage_students')
def manage_students():
    if 'loggedin' not in session or session['role'] != 'admin':
        return redirect('/login')

    try:
        connection = get_db_connection()
        with connection.cursor() as cursor:
            cursor.execute("SELECT * FROM applications ORDER BY application_no ASC")
            students = cursor.fetchall()
    except pymysql.MySQLError as e:
        flash(f"Database error: {e}", "error")
        students = []
    finally:
        connection.close()

    return render_template('manage_students.html', students=students)


# Edit Application
@app.route('/edit_student/<int:application_no>', methods=['GET', 'POST'])
def edit_student(application_no):
    if 'loggedin' not in session or session['role'] != 'admin':
        return redirect('/login')

    connection = get_db_connection()
    cursor = connection.cursor()

    if request.method == 'POST':
        form_data = request.form.to_dict()

        # Dynamically create update query
        update_query = "UPDATE applications SET "
        update_query += ", ".join([f"{key} = %s" for key in form_data.keys()])
        update_query += " WHERE application_no = %s"

        values = list(form_data.values()) + [application_no]

        try:
            cursor.execute(update_query, values)
            connection.commit()
            flash("Application updated successfully!", "success")
        except pymysql.MySQLError as e:
            flash(f"Error updating application: {e}", "error")
        finally:
            connection.close()

        return redirect('/manage_students')

    # Fetch student details
    try:
        cursor.execute("SELECT * FROM applications WHERE application_no = %s", (application_no,))
        student = cursor.fetchone()
    except pymysql.MySQLError as e:
        flash(f"Error fetching student details: {e}", "error")
        student = None
    finally:
        connection.close()

    return render_template('edit_student.html', student=student)


# Delete Application
@app.route('/delete_student/<int:application_no>')
def delete_student(application_no):
    if 'loggedin' not in session or session['role'] != 'admin':
        return redirect('/login')

    try:
        connection = get_db_connection()
        with connection.cursor() as cursor:
            cursor.execute("DELETE FROM applications WHERE application_no = %s", (application_no,))
        connection.commit()
        flash("Application deleted successfully!", "success")
    except pymysql.MySQLError as e:
        flash(f"Error deleting application: {e}", "error")
    finally:
        connection.close()

    return redirect('/manage_students')



@app.route("/download/<app_no>")
def download_pdf(app_no):
    pdf_path = os.path.join(UPLOAD_FOLDER, f"{app_no}.pdf")
    return send_file(pdf_path, as_attachment=True)

# Report Page
# Update the /report route
@app.route('/report')
def report():
    if 'loggedin' not in session or session['role'] != 'admin':
        return redirect('/login')

    # Check if there's a processed file in session
    last_file = session.get('last_processed_file')
    if not last_file:
        return "No report available. Please process a file first.", 400

    file_path = os.path.join(app.config['DOWNLOAD_FOLDER'], last_file)
    if not os.path.exists(file_path):
        return "Processed file not found!", 404

    # Read the data from each sheet
    selected_students = pd.read_excel(file_path, sheet_name="Selected Students")
    waiting_list = pd.read_excel(file_path, sheet_name="Waiting List")
    rejected_list = pd.read_excel(file_path, sheet_name="Rejected List")

    # Define columns to display
    required_columns = [
        "APPLICATION_NO", "NAME", "GENDER", "COMMUNITY", "EMAIL", "BRANCH_CHOICE",
        "UG_COLLEGE_STUDIED", "DEGREE", "BRANCH_OF_STUDY", "UNIVERSITY_NAME", "UNIVERSITY_REG_NUMBER",
        "PART1_AVG", "PART2_AVG", "PART3_AVG", "PART4_AVG",
        "YEAR1_CGPA_PERFORMANCE", "YEAR2_CGPA_PERFORMANCE", "YEAR3_CGPA_PERFORMANCE", "RANK"
    ]

    # Filter and convert to HTML
    selected_students_display = selected_students[required_columns]
    waiting_list_display = waiting_list[required_columns]
    rejected_list_display = rejected_list[required_columns]

    selected_students_html = selected_students_display.to_html(index=False)
    waiting_list_html = waiting_list_display.to_html(index=False)
    rejected_list_html = rejected_list_display.to_html(index=False)

    # Get counts
    selected_count = len(selected_students)
    waiting_count = len(waiting_list)
    rejected_count = len(rejected_list)

    return render_template('report.html',
                           last_file=last_file,
                           selected_students_html=selected_students_html,
                           waiting_list_html=waiting_list_html,
                           rejected_list_html=rejected_list_html,
                           selected_count=selected_count,
                           waiting_count=waiting_count,
                           rejected_count=rejected_count)

# New routes to download individual lists
@app.route('/download_selected')
def download_selected():
    if 'loggedin' not in session or session['role'] != 'admin':
        return redirect('/login')

    last_file = session.get('last_processed_file')
    if not last_file:
        return "No file available for download.", 400

    file_path = os.path.join(app.config['DOWNLOAD_FOLDER'], last_file)
    if not os.path.exists(file_path):
        return "File not found!", 404

    # Read the "Selected Students" sheet
    df = pd.read_excel(file_path, sheet_name="Selected Students")
    output = BytesIO()
    df.to_excel(output, index=False)
    output.seek(0)

    return send_file(output, as_attachment=True, download_name="Selected_Students.xlsx")

@app.route('/download_waiting')
def download_waiting():
    if 'loggedin' not in session or session['role'] != 'admin':
        return redirect('/login')

    last_file = session.get('last_processed_file')
    if not last_file:
        return "No file available for download.", 400

    file_path = os.path.join(app.config['DOWNLOAD_FOLDER'], last_file)
    if not os.path.exists(file_path):
        return "File not found!", 404

    # Read the "Waiting List" sheet
    df = pd.read_excel(file_path, sheet_name="Waiting List")
    output = BytesIO()
    df.to_excel(output, index=False)
    output.seek(0)

    return send_file(output, as_attachment=True, download_name="Waiting_List.xlsx")

@app.route('/download_rejected')
def download_rejected():
    if 'loggedin' not in session or session['role'] != 'admin':
        return redirect('/login')

    last_file = session.get('last_processed_file')
    if not last_file:
        return "No file available for download.", 400

    file_path = os.path.join(app.config['DOWNLOAD_FOLDER'], last_file)
    if not os.path.exists(file_path):
        return "File not found!", 404

    # Read the "Rejected List" sheet
    df = pd.read_excel(file_path, sheet_name="Rejected List")
    output = BytesIO()
    df.to_excel(output, index=False)
    output.seek(0)

    return send_file(output, as_attachment=True, download_name="Rejected_List.xlsx")

# Logout route
@app.route('/logout')
def logout():
    session.pop('loggedin', None)
    session.pop('username', None)
    session.pop('role', None)
    return redirect('/login')

if __name__ == '__main__':
    app.run(debug=True)
