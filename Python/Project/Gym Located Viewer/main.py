from flask import Flask, render_template, request, redirect, url_for, flash, session
from flask_mail import Mail, Message
import sqlite3

app = Flask(__name__)
app.secret_key = 'your_secret_key_here'  # Change this to a secure key

# Mail configuration
app.config['MAIL_SERVER'] = 'smtp.gmail.com'
app.config['MAIL_PORT'] = 587
app.config['MAIL_USE_TLS'] = True
app.config['MAIL_USERNAME'] = 'Your_email@gmail.com'
app.config['MAIL_PASSWORD'] = 'SMTP KEY'
app.config['MAIL_DEFAULT_SENDER'] = 'your_email@gmail.com'
mail = Mail(app)


# Database initialization
def init_db():
    conn = sqlite3.connect('database.db')
    c = conn.cursor()

    # Create Users table with role
    c.execute('''CREATE TABLE IF NOT EXISTS users 
                (id INTEGER PRIMARY KEY AUTOINCREMENT,
                 name TEXT NOT NULL,
                 email TEXT UNIQUE NOT NULL,
                 password TEXT NOT NULL,
                 phone TEXT NOT NULL,
                 role TEXT NOT NULL DEFAULT 'user')''')

    # Create Gyms table with three image columns
    c.execute('''CREATE TABLE IF NOT EXISTS gyms 
                (id INTEGER PRIMARY KEY AUTOINCREMENT,
                 name TEXT NOT NULL,
                 address TEXT NOT NULL,
                 phone TEXT NOT NULL,
                 hours TEXT NOT NULL,
                 image1 TEXT,
                 image2 TEXT,
                 image3 TEXT,
                 package_3months INTEGER NOT NULL,
                 package_6months INTEGER NOT NULL,
                 package_12months INTEGER NOT NULL,
                 avg_rating REAL DEFAULT 0.0)''')

    # Create Enquiries table
    c.execute('''CREATE TABLE IF NOT EXISTS enquiries 
                (id INTEGER PRIMARY KEY AUTOINCREMENT,
                 gym_id INTEGER NOT NULL,
                 name TEXT NOT NULL,
                 email TEXT NOT NULL,
                 phone TEXT NOT NULL,
                 message TEXT NOT NULL,
                 timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
                 FOREIGN KEY (gym_id) REFERENCES gyms(id))''')

    # Create Reviews table
    c.execute('''CREATE TABLE IF NOT EXISTS reviews 
                (id INTEGER PRIMARY KEY AUTOINCREMENT,
                 gym_id INTEGER NOT NULL,
                 user_name TEXT NOT NULL,
                 rating INTEGER NOT NULL CHECK (rating >= 1 AND rating <= 5),
                 review_text TEXT NOT NULL,
                 timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
                 FOREIGN KEY (gym_id) REFERENCES gyms(id))''')

    # Insert default admin user if not exists
    c.execute('SELECT COUNT(*) FROM users WHERE email = ?', ('admin@example.com',))
    if c.fetchone()[0] == 0:
        c.execute('INSERT INTO users (name, email, password, phone, role) VALUES (?, ?, ?, ?, ?)',
                  ('Admin', 'admin@example.com', 'admin', '0000000000', 'admin'))

    # Check if gyms table is empty before inserting data
    c.execute('SELECT COUNT(*) FROM gyms')
    gym_count = c.fetchone()[0]

    if gym_count == 0:  # Only insert if the table is empty
        gyms_data = [
            ('Bodyzeal Fitworks', 'No : 1063, Avinashi Road, Gym Road, Nav India, Peelamedu, Coimbatore - 641004 (Near By Junior Kuppanna)', '08734920568', 'Available until 10:00 pm', 'bodyzeal.jpg', 'bodyzeal2.jpg', 'bodyzeal3.jpg', 3000, 5500, 10000, 4.5),
            ('Monster Life Style Fitness Studio', 'Sai Nataraja Complex, Maruthamalai Main Road, Vadavalli, Coimbatore - 641041 (Opposite Daksha Appartments)', '08401426250', 'Available until 9:30 pm', 'monster.jpg', 'monster2.jpg', 'monster3.jpg', 2800, 5200, 9500, 4.2),
            ('Cristal Icon Fitness Centre For Men', 'No.17/1, First Floor, Perumal Kovil Street, Olymbus Ramanathapuram, Ramanathapuram Coimbatore, Coimbatore - 641045 (Near Perumalkovil)', '08128908764', 'Open until 9:30 pm', 'cristal.jpg', 'cristal2.jpg', 'cristal3.jpg', 3200, 5800, 10500, 4.0),
            ('Highway Fitness and Unisex Gym', 'Amitha Complex, Railway Station Road, Ettimadai, Coimbatore - 641112 (Near KK Mahal)', '08147643949', 'Open until 9:00 pm', 'highway.jpg', 'highway2.jpg', 'highway3.jpg', 2500, 4800, 9000, 3.8),
            ('Authentic Fitness', 'No 2A2, Sakthi Road, Saravanampatti, Coimbatore - 641035 (Near By Meetur Transport)', '08460264783', 'Available until 9:00 pm', 'authentic.jpg', 'authentic2.jpg', 'bodyzeal3.jpg', 2900, 5300, 9700, 4.3),
            ('Posh Gym International', 'Shop No 147 & 148, Second Floor, DB Road, RS Puram SWCoimbatore, Coimbatore - 641002 (Opp to Icici Bank)', '07947129237', 'Open until 9:30 pm', 'posh.jpg', 'monster2.jpg', 'bodyzeal3.jpg', 3500, 6500, 12000, 4.7),
            ("Ravi's Cross Fit", '1/6/3c, Behind Ganga Hospitals, Saibaba Colony, Coimbatore - 641011 (Next to Ganga Hospital Road)', '08460499878', 'Available until 8:00 pm', 'ravi1.jpg', 'highway2.jpg', 'bodyzeal3.jpg', 3100, 5700, 10300, 4.1),
            ('Kumbu Fitness', 'SF No.396/1-c, 1d, Thudiyalur Road, Saravanampatti, Coimbatore - 641035 (Near By Kumaraguru College)', '08460455624', 'Open until 10:00 pm', 'kumbu.jpg', 'highway2.jpg', 'bodyzeal2.jpg', 2700, 5000, 9200, 3.9),
            ('Arokiya Multi Gym and Royals Fitness Centre', 'No.10, Annur Road, Mettupalayam, Coimbatore - 641301 (Kotak Mahindra Bank Upstair)', '07942678428', 'Open until 10:00 pm', 'arokiya.jpg', 'authentic2.jpg', 'cristal2.jpg', 2600, 4900, 9100, 4.0),
            ('Evolve Plus Grand Family Fitness Studio', '188A, Sri Devi Nagar, Thudialur, Coimbatore - 641034 (Near Sri Murugan Theatre)', '08460423793', 'Open until 10:00 pm', 'evolve.jpg', 'evolve2.jpg', 'cristal2.jpg', 3000, 5500, 10000, 4.4),
            ("Ravi's Crossfit", 'Sathy Road, Bharathy Nagar, Ganapathy, Coimbatore - 641006', '08460445133', 'Available until 8:00 pm', 'ravi1.jpg', 'authentic2.jpg', 'arokiya.jpg', 3100, 5700, 10300, 4.1),
            ('Evolutions Fitness Club', 'No:272B, VKS Complex, 1st Floor, NSR Road, Saibaba Colony, Saibaba Colony, Coimbatore - 641011 (Above KVB)', '08105348014', 'Available until 9:30 pm', 'evolutions.jpg', 'evolutions2.jpg', 'evolutions3.jpg', 3300, 6000, 11000, 4.6),
            ('Winner Gym & Fitness Centre', 'No : 385, Second Floor, Avinashi Road, Peelamedu, Coimbatore - 641004 (Opposite to PSG Tech College)', '07942688826', 'Available until 9:00 pm', 'winner.jpg', 'evolutions3.jpg', 'cristal2.jpg', 2800, 5200, 9500, 4.2),
            ('Genetix Fitness Center', 'No 192, Sathy Road, Bharathi Nagar, Ganapathy, Coimbatore - 641006 (Opp to Annapoorna)', '07942686608', 'Open until 9:00 pm', 'genetix.jpg', 'genetix2.jpg', 'genetix3.jpg', 2900, 5300, 9700, 4.3),
            ('Climb Oon', 'No 372, Chil Sez Road, Keeranatham, Coimbatore - 641035', '07942685614', 'Open until 9:00 pm', 'climb.jpg', 'climb2.jpg', 'climb3.jpg', 2700, 5000, 9200, 3.7),
            ('Rk Fitness Village Crossfitness Center', 'No.2, Mappillaigounder Thottam, Navaoor, Vadavalli, Coimbatore - 641041 (Near Chavara Vidya Bhavan School)', '08460518903', 'Opens at 05:00 AM', 'rkfitness.jpg', 'monster2.jpg', 'highway2.jpg', 2800, 5200, 9500, 4.1),
            ('V Tone Fitness Studio', 'No.345, Rajagopal Layout, Peelamedu, Coimbatore - 641004 (Near Sri Gopal Naidu Children School)', '07947117236', 'Opens at 05:30 AM', 'vtone.jpg', 'cristal2.jpg', 'monster2.jpg', 2900, 5400, 9800, 4.3),
            ('Red Fitness Center', 'No 12, Neelikonampalayam, Coimbatore - 641033 (Near Bharath Matriculation School)', '8754338974', 'Opens at 6:00 AM tomorrow', 'redfitness.jpg', 'cristal2.jpg', 'highway2.jpg', 2600, 4800, 9000, 3.9),
            ('Ultimate Gym And Fitness Studio', 'No 3/95, Katoor Road, Papanaickenpalayam, Coimbatore - 641037 (Near Federal Bank & Gknm Hospital and Manis High School)', '07947118399', 'Opens at 07:00 AM', 'ultimate.jpg', 'bodyzeal2.jpg', 'monster2.jpg', 3100, 5700, 10300, 4.2),
            ('Raw Fitness', 'No 56, Avinashi Main Road, Hopes, Coimbatore - 641004 (Fun Mall Near)', '07947133883', 'Open 24 Hrs', 'rawfitness.jpg', 'ultimate.jpg', 'redfitness.jpg', 3400, 6200, 11500, 4.5)
        ]
        c.executemany('INSERT INTO gyms (name, address, phone, hours, image1, image2, image3, package_3months, package_6months, package_12months, avg_rating) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)', gyms_data)

    # Insert sample reviews if not exists
    c.execute('SELECT COUNT(*) FROM reviews')
    review_count = c.fetchone()[0]
    if review_count == 0:
        sample_reviews = [
            (1, 'John Doe', 5, 'Great gym with excellent equipment!'),
            (1, 'Jane Smith', 4, 'Friendly staff, but could use more space.'),
            (2, 'Mike Ross', 4, 'Good value for money, clean environment.'),
            (3, 'Sarah Lee', 4, 'Nice atmosphere, highly recommend.'),
            (4, 'Tom Brown', 3, 'Decent gym, but parking is an issue.'),
            (5, 'Emily White', 5, 'Best gym in the area!'),
            (6, 'Priya Sharma', 5, 'Luxurious facilities, worth the price!'),
            (7, 'Rahul Kumar', 4, 'Great trainers, good vibe.'),
            (8, 'Lisa Ray', 3, 'Okay, but could improve cleanliness.'),
            (9, 'David Black', 4, 'Spacious and well-equipped.'),
            (10, 'Anita Patel', 5, 'Perfect for family fitness!'),
            (11, 'Vikram Singh', 4, 'Solid gym, convenient location.'),
            (12, 'Sofia Khan', 5, 'Top-notch equipment and staff.'),
            (13, 'Arjun Nair', 4, 'Good for serious lifters.'),
            (14, 'Meera Joshi', 4, 'Friendly community, great workouts.'),
            (15, 'Alex Green', 3, 'Nice, but limited hours.'),
            (16, 'Karthik Reddy', 4, 'Early morning sessions are a plus!'),
            (17, 'Neha Gupta', 5, 'Super clean and well-maintained.'),
            (18, 'Ravi Menon', 3, 'Good, but equipment needs an update.'),
            (19, 'Sneha Pillai', 4, 'Friendly trainers, convenient spot.'),
            (20, 'Amit Verma', 5, 'Love the 24-hour access!')
        ]
        c.executemany('INSERT INTO reviews (gym_id, user_name, rating, review_text) VALUES (?, ?, ?, ?)', sample_reviews)

    conn.commit()
    conn.close()


# Routes (unchanged except for gym_detail)
@app.route('/')
def index():
    return redirect(url_for('login'))


@app.route('/login', methods=['GET', 'POST'])
def login():
    if request.method == 'POST':
        email = request.form['email']
        password = request.form['password']
        conn = sqlite3.connect('database.db')
        c = conn.cursor()
        c.execute('SELECT * FROM users WHERE email = ? AND password = ?', (email, password))
        user = c.fetchone()
        conn.close()
        if user:
            session['user_id'] = user[0]
            session['role'] = user[5]
            if user[5] == 'admin':
                return redirect(url_for('admin_dashboard'))
            else:
                return redirect(url_for('home'))
        else:
            flash('Invalid credentials')
    return render_template('login.html')


@app.route('/register', methods=['GET', 'POST'])
def register():
    if request.method == 'POST':
        name = request.form['name']
        email = request.form['email']
        password = request.form['password']
        phone = request.form['phone']
        try:
            conn = sqlite3.connect('database.db')
            c = conn.cursor()
            c.execute('INSERT INTO users (name, email, password, phone, role) VALUES (?, ?, ?, ?, ?)',
                      (name, email, password, phone, 'user'))
            conn.commit()
            conn.close()
            flash('Account created successfully!')
            return redirect(url_for('login'))
        except sqlite3.IntegrityError:
            flash('Email already exists!')
    return render_template('register.html')


@app.route('/home', methods=['GET', 'POST'])
def home():
    if 'user_id' not in session:
        return redirect(url_for('login'))
    gyms = []
    search_query = ""
    if request.method == 'POST':
        search_query = request.form['search'].strip()
        conn = sqlite3.connect('database.db')
        c = conn.cursor()
        c.execute('SELECT * FROM gyms WHERE name LIKE ?', ('%' + search_query + '%',))
        gyms = c.fetchall()
        conn.close()
    else:
        conn = sqlite3.connect('database.db')
        c = conn.cursor()
        c.execute('SELECT * FROM gyms')
        gyms = c.fetchall()
        conn.close()
    return render_template('home.html', gyms=gyms, search_query=search_query)


@app.route('/gym/<int:gym_id>')
def gym_detail(gym_id):
    if 'user_id' not in session:
        return redirect(url_for('login'))
    conn = sqlite3.connect('database.db')
    c = conn.cursor()
    c.execute('SELECT * FROM gyms WHERE id = ?', (gym_id,))
    gym = c.fetchone()
    c.execute('SELECT user_name, rating, review_text, timestamp FROM reviews WHERE gym_id = ?', (gym_id,))
    reviews = c.fetchall()
    conn.close()
    return render_template('gym_detail.html', gym=gym, reviews=reviews)


@app.route('/enquiry/<int:gym_id>', methods=['GET', 'POST'])
def enquiry(gym_id):
    if 'user_id' not in session:
        return redirect(url_for('login'))
    conn = sqlite3.connect('database.db')
    c = conn.cursor()
    c.execute('SELECT name FROM gyms WHERE id = ?', (gym_id,))
    gym_name = c.fetchone()[0]
    conn.close()
    if request.method == 'POST':
        name = request.form['name']
        email = request.form['email']
        phone = request.form['phone']
        message = request.form['message']
        conn = sqlite3.connect('database.db')
        c = conn.cursor()
        c.execute('''INSERT INTO enquiries (gym_id, name, email, phone, message) 
                     VALUES (?, ?, ?, ?, ?)''', (gym_id, name, email, phone, message))
        conn.commit()
        conn.close()
        flash('Enquiry submitted successfully!')
        return redirect(url_for('home'))
    return render_template('enquiry.html', gym_name=gym_name, gym_id=gym_id)


@app.route('/admin')
def admin_dashboard():
    if 'user_id' not in session or session.get('role') != 'admin':
        return redirect(url_for('login'))
    conn = sqlite3.connect('database.db')
    c = conn.cursor()
    c.execute('SELECT * FROM enquiries')
    enquiries = c.fetchall()
    conn.close()
    return render_template('admin_dashboard.html', enquiries=enquiries)


@app.route('/notify/<int:enquiry_id>')
def notify_user(enquiry_id):
    if 'user_id' not in session or session.get('role') != 'admin':
        return redirect(url_for('login'))
    conn = sqlite3.connect('database.db')
    c = conn.cursor()
    c.execute(
        'SELECT enquiries.email, enquiries.name, gyms.name, gyms.package_3months, gyms.package_6months, gyms.package_12months FROM enquiries JOIN gyms ON enquiries.gym_id = gyms.id WHERE enquiries.id = ?',
        (enquiry_id,))
    enquiry = c.fetchone()
    conn.close()
    if enquiry:
        user_email, user_name, gym_name, package_3months, package_6months, package_12months = enquiry
        msg = Message(
            subject=f"Enquiry Follow-up for {gym_name}",
            recipients=[user_email],
            body=f"Dear {user_name},\n\nThank you for your enquiry about {gym_name}. We're reaching out to follow up on your interest. Here are our membership packages:\n\n- 3 Months: ₹{package_3months}\n- 6 Months: ₹{package_6months}\n- 12 Months: ₹{package_12months}\n\nPlease let us know if you have any questions or would like to schedule a visit!\n\nBest regards,\nGym Located Viewer Team"
        )
        try:
            mail.send(msg)
            flash(f'Notification sent to {user_email} successfully!')
        except Exception as e:
            flash(f'Failed to send notification: {str(e)}')
    return redirect(url_for('admin_dashboard'))


@app.route('/logout')
def logout():
    session.pop('user_id', None)
    session.pop('role', None)
    flash('Logged out successfully!')
    return redirect(url_for('login'))


if __name__ == '__main__':
    init_db()
    app.run(debug=True)
