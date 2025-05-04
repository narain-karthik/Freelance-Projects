import tkinter as tk
from tkinter import messagebox
from tkinter import ttk
import matplotlib.pyplot as plt
import sqlite3

# Database initialization
conn = sqlite3.connect('employee_salary.db')
c = conn.cursor()
c.execute('''
CREATE TABLE IF NOT EXISTS employee_salary (
    emp_id INTEGER PRIMARY KEY,
    name TEXT,
    salary REAL
)
''')
conn.commit()

# Global variable for admin login window
admin_login_window = None


# Function to validate admin credentials
def validate_admin_login(username, password):
    return username == "admin" and password == "admin"


# Function to open the main application after successful login
def open_main_app():
    global admin_login_window
    if admin_login_window:
        admin_login_window.destroy()
        admin_login_window = None
    create_home_page()


# Function to handle admin login
def open_admin_login():
    global admin_login_window
    admin_login_window = tk.Tk()
    admin_login_window.title("Admin Login")
    admin_login_window.geometry("300x250")
    admin_login_window.configure(bg='#f0f0f0')

    tk.Label(admin_login_window, text="Admin Login",
             font=("Arial", 16, "bold"),
             bg='#f0f0f0',
             fg='#333333').pack(pady=20)

    tk.Label(admin_login_window, text="Username:",
             font=("Arial", 11),
             bg='#f0f0f0',
             fg='#444444').pack()
    username_entry = tk.Entry(admin_login_window, font=("Arial", 11), width=20, bd=2, relief="flat")
    username_entry.pack(pady=5)

    tk.Label(admin_login_window, text="Password:",
             font=("Arial", 11),
             bg='#f0f0f0',
             fg='#444444').pack()
    password_entry = tk.Entry(admin_login_window, show='*', font=("Arial", 11), width=20, bd=2, relief="flat")
    password_entry.pack(pady=5)

    def login():
        username = username_entry.get()
        password = password_entry.get()
        if validate_admin_login(username, password):
            open_main_app()
        else:
            messagebox.showerror("Error", "Invalid username or password.")

    login_btn = tk.Button(admin_login_window, text="Login",
                          command=login,
                          font=("Arial", 11, "bold"),
                          bg='#4CAF50',
                          fg='white',
                          width=12,
                          bd=0,
                          relief="flat",
                          cursor="hand2")
    login_btn.pack(pady=20)
    login_btn.bind("<Enter>", lambda e: login_btn.configure(bg='#45a049'))
    login_btn.bind("<Leave>", lambda e: login_btn.configure(bg='#4CAF50'))

    admin_login_window.protocol("WM_DELETE_WINDOW", on_closing)
    admin_login_window.mainloop()


# Function to open the employee salary module
def open_employee_salary_module(parent_window):
    parent_window.destroy()
    salary_window = tk.Tk()
    salary_window.title("Add Employee Salary Module")
    salary_window.geometry("400x400")
    salary_window.configure(bg='#f0f0f0')

    main_frame = tk.Frame(salary_window, bg='#f0f0f0', padx=20, pady=20)
    main_frame.pack(expand=True)

    tk.Label(main_frame, text="Add Employee Salary",
             font=("Arial", 18, "bold"),
             bg='#f0f0f0',
             fg='#333333').pack(pady=(0, 20))

    label_style = {"font": ("Arial", 11), "bg": '#f0f0f0', "fg": '#444444'}
    entry_style = {"font": ("Arial", 11), "width": 25, "bd": 2, "relief": "flat"}

    tk.Label(main_frame, text="Employee ID:", **label_style).pack(pady=(10, 2))
    emp_id_entry = tk.Entry(main_frame, **entry_style)
    emp_id_entry.pack(pady=(0, 10))

    tk.Label(main_frame, text="Employee Name:", **label_style).pack(pady=(10, 2))
    emp_name_entry = tk.Entry(main_frame, **entry_style)
    emp_name_entry.pack(pady=(0, 10))

    tk.Label(main_frame, text="Employee Salary:", **label_style).pack(pady=(10, 2))
    emp_salary_entry = tk.Entry(main_frame, **entry_style)
    emp_salary_entry.pack(pady=(0, 10))

    def add_employee():
        emp_id = emp_id_entry.get()
        emp_name = emp_name_entry.get()
        emp_salary = emp_salary_entry.get()
        try:
            emp_id = int(emp_id)
            emp_salary = float(emp_salary)
            if emp_name.strip() == "":
                raise ValueError("Name cannot be empty")
            c.execute("INSERT INTO employee_salary (emp_id, name, salary) VALUES (?, ?, ?)",
                      (emp_id, emp_name, emp_salary))
            conn.commit()
            messagebox.showinfo("Success", "Employee added successfully!")
            emp_id_entry.delete(0, tk.END)
            emp_name_entry.delete(0, tk.END)
            emp_salary_entry.delete(0, tk.END)
        except ValueError as e:
            messagebox.showerror("Error", str(e) if str(e) != "Name cannot be empty" else "Please enter valid data")
        except sqlite3.IntegrityError:
            messagebox.showerror("Error", "Employee ID must be unique")
        except Exception as e:
            messagebox.showerror("Error", str(e))

    button_frame = tk.Frame(main_frame, bg='#f0f0f0')
    button_frame.pack(pady=20)

    add_btn = tk.Button(button_frame, text="Add Employee",
                        command=add_employee,
                        bg='#4CAF50',
                        fg='white',
                        font=("Arial", 11, "bold"),
                        width=12,
                        bd=0,
                        relief="flat",
                        cursor="hand2")
    add_btn.grid(row=0, column=0, padx=10)

    back_btn = tk.Button(button_frame, text="Back to Home",
                         command=lambda: back_to_home(salary_window),
                         bg='#2196F3',
                         fg='white',
                         font=("Arial", 11, "bold"),
                         width=12,
                         bd=0,
                         relief="flat",
                         cursor="hand2")
    back_btn.grid(row=0, column=1, padx=10)

    add_btn.bind("<Enter>", lambda e: add_btn.configure(bg='#45a049'))
    add_btn.bind("<Leave>", lambda e: add_btn.configure(bg='#4CAF50'))
    back_btn.bind("<Enter>", lambda e: back_btn.configure(bg='#1976D2'))
    back_btn.bind("<Leave>", lambda e: back_btn.configure(bg='#2196F3'))

    salary_window.protocol("WM_DELETE_WINDOW", on_closing)
    salary_window.mainloop()


# Function to open the salary update module
def open_salary_update_module(parent_window):
    parent_window.destroy()
    update_window = tk.Tk()
    update_window.title("Salary Increment/Update Module")
    update_window.geometry("400x350")
    update_window.configure(bg='#f0f0f0')

    main_frame = tk.Frame(update_window, bg='#f0f0f0', padx=20, pady=20)
    main_frame.pack(expand=True)

    tk.Label(main_frame, text="Update Employee Salary",
             font=("Arial", 18, "bold"),
             bg='#f0f0f0',
             fg='#333333').pack(pady=(0, 20))

    label_style = {"font": ("Arial", 11), "bg": '#f0f0f0', "fg": '#444444'}
    entry_style = {"font": ("Arial", 11), "width": 25, "bd": 2, "relief": "flat"}

    tk.Label(main_frame, text="Employee ID:", **label_style).pack(pady=(10, 2))
    emp_id_entry = tk.Entry(main_frame, **entry_style)
    emp_id_entry.pack(pady=(0, 10))

    tk.Label(main_frame, text="New Salary:", **label_style).pack(pady=(10, 2))
    new_salary_entry = tk.Entry(main_frame, **entry_style)
    new_salary_entry.pack(pady=(0, 10))

    def update_salary():
        emp_id = emp_id_entry.get()
        new_salary = new_salary_entry.get()
        try:
            emp_id = int(emp_id)
            new_salary = float(new_salary)
            c.execute("UPDATE employee_salary SET salary = ? WHERE emp_id = ?", (new_salary, emp_id))
            if c.rowcount > 0:
                conn.commit()
                messagebox.showinfo("Success", "Salary updated successfully!")
                emp_id_entry.delete(0, tk.END)
                new_salary_entry.delete(0, tk.END)
            else:
                messagebox.showerror("Error", "Employee not found")
        except ValueError:
            messagebox.showerror("Error", "Please enter valid data")
        except Exception as e:
            messagebox.showerror("Error", str(e))

    button_frame = tk.Frame(main_frame, bg='#f0f0f0')
    button_frame.pack(pady=20)

    update_btn = tk.Button(button_frame, text="Update Salary",
                           command=update_salary,
                           bg='#4CAF50',
                           fg='white',
                           font=("Arial", 11, "bold"),
                           width=12,
                           bd=0,
                           relief="flat",
                           cursor="hand2")
    update_btn.grid(row=0, column=0, padx=10)

    back_btn = tk.Button(button_frame, text="Back to Home",
                         command=lambda: back_to_home(update_window),
                         bg='#2196F3',
                         fg='white',
                         font=("Arial", 11, "bold"),
                         width=12,
                         bd=0,
                         relief="flat",
                         cursor="hand2")
    back_btn.grid(row=0, column=1, padx=10)

    update_btn.bind("<Enter>", lambda e: update_btn.configure(bg='#45a049'))
    update_btn.bind("<Leave>", lambda e: update_btn.configure(bg='#4CAF50'))
    back_btn.bind("<Enter>", lambda e: back_btn.configure(bg='#1976D2'))
    back_btn.bind("<Leave>", lambda e: back_btn.configure(bg='#2196F3'))

    update_window.protocol("WM_DELETE_WINDOW", on_closing)
    update_window.mainloop()


# Function to open the salary search module
def open_salary_search_module(parent_window):
    parent_window.destroy()
    search_window = tk.Tk()
    search_window.title("Salary Search & Filter Module")
    search_window.geometry("400x300")
    search_window.configure(bg='#f0f0f0')

    main_frame = tk.Frame(search_window, bg='#f0f0f0', padx=20, pady=20)
    main_frame.pack(expand=True)

    tk.Label(main_frame, text="Search Employee Salary",
             font=("Arial", 18, "bold"),
             bg='#f0f0f0',
             fg='#333333').pack(pady=(0, 20))

    label_style = {"font": ("Arial", 11), "bg": '#f0f0f0', "fg": '#444444'}
    entry_style = {"font": ("Arial", 11), "width": 25, "bd": 2, "relief": "flat"}

    tk.Label(main_frame, text="Employee ID:", **label_style).pack(pady=(10, 2))
    emp_id_entry = tk.Entry(main_frame, **entry_style)
    emp_id_entry.pack(pady=(0, 10))

    def search_salary():
        emp_id = emp_id_entry.get()
        try:
            emp_id = int(emp_id)
            c.execute("SELECT * FROM employee_salary WHERE emp_id = ?", (emp_id,))
            employee = c.fetchone()
            if employee:
                messagebox.showinfo("Employee Salary",
                                    f"ID: {employee[0]}\nName: {employee[1]}\nSalary: {employee[2]:.2f}rs")
            else:
                messagebox.showerror("Error", "Employee not found")
        except ValueError:
            messagebox.showerror("Error", "Please enter a valid Employee ID")

    button_frame = tk.Frame(main_frame, bg='#f0f0f0')
    button_frame.pack(pady=20)

    search_btn = tk.Button(button_frame, text="Search Salary",
                           command=search_salary,
                           bg='#4CAF50',
                           fg='white',
                           font=("Arial", 11, "bold"),
                           width=12,
                           bd=0,
                           relief="flat",
                           cursor="hand2")
    search_btn.grid(row=0, column=0, padx=10)

    back_btn = tk.Button(button_frame, text="Back to Home",
                         command=lambda: back_to_home(search_window),
                         bg='#2196F3',
                         fg='white',
                         font=("Arial", 11, "bold"),
                         width=12,
                         bd=0,
                         relief="flat",
                         cursor="hand2")
    back_btn.grid(row=0, column=1, padx=10)

    search_btn.bind("<Enter>", lambda e: search_btn.configure(bg='#45a049'))
    search_btn.bind("<Leave>", lambda e: search_btn.configure(bg='#4CAF50'))
    back_btn.bind("<Enter>", lambda e: back_btn.configure(bg='#1976D2'))
    back_btn.bind("<Leave>", lambda e: back_btn.configure(bg='#2196F3'))

    search_window.protocol("WM_DELETE_WINDOW", on_closing)
    search_window.mainloop()


# Function to open the reduce salary module
def open_reduce_salary_module(parent_window):
    parent_window.destroy()
    reduce_window = tk.Tk()
    reduce_window.title("Reduce Salary Module")
    reduce_window.geometry("400x450")
    reduce_window.configure(bg='#f0f0f0')

    main_frame = tk.Frame(reduce_window, bg='#f0f0f0', padx=20, pady=20)
    main_frame.pack(expand=True)

    tk.Label(main_frame, text="Reduce Employee Salary",
             font=("Arial", 18, "bold"),
             bg='#f0f0f0',
             fg='#333333').pack(pady=(0, 20))

    label_style = {"font": ("Arial", 11), "bg": '#f0f0f0', "fg": '#444444'}
    entry_style = {"font": ("Arial", 11), "width": 25, "bd": 2, "relief": "flat"}

    tk.Label(main_frame, text="Employee ID:", **label_style).pack(pady=(10, 2))
    emp_id_entry = tk.Entry(main_frame, **entry_style)
    emp_id_entry.pack(pady=(0, 10))

    tk.Label(main_frame, text="Employee Name:", **label_style).pack(pady=(10, 2))
    emp_name_entry = tk.Entry(main_frame, state='disabled',
                              font=("Arial", 11),
                              width=25,
                              bg='#e0e0e0',
                              bd=2,
                              relief="flat")
    emp_name_entry.pack(pady=(0, 10))

    tk.Label(main_frame, text="Number of Days (1 day = 100rs):", **label_style).pack(pady=(10, 2))
    days_entry = tk.Entry(main_frame, **entry_style)
    days_entry.pack(pady=(0, 10))

    current_salary_label = tk.Label(main_frame, text="Current Salary: Not Available",
                                    font=("Arial", 10, "italic"),
                                    bg='#f0f0f0',
                                    fg='#666666')
    current_salary_label.pack(pady=(10, 10))

    def fetch_employee_details(*args):
        emp_id = emp_id_entry.get()
        if emp_id:
            try:
                emp_id = int(emp_id)
                c.execute("SELECT name, salary FROM employee_salary WHERE emp_id = ?", (emp_id,))
                employee = c.fetchone()
                emp_name_entry.config(state='normal')
                emp_name_entry.delete(0, tk.END)
                if employee:
                    emp_name_entry.insert(0, employee[0])
                    current_salary_label.config(text=f"Current Salary: {employee[1]:.2f}rs")
                else:
                    emp_name_entry.insert(0, "Employee not found")
                    current_salary_label.config(text="Current Salary: Not Available")
                emp_name_entry.config(state='disabled')
            except ValueError:
                emp_name_entry.config(state='normal')
                emp_name_entry.delete(0, tk.END)
                emp_name_entry.config(state='disabled')
                current_salary_label.config(text="Current Salary: Not Available")

    emp_id_entry.bind('<KeyRelease>', fetch_employee_details)

    def reduce_salary():
        emp_id = emp_id_entry.get()
        days = days_entry.get()
        try:
            emp_id = int(emp_id)
            days = int(days)
            if days < 0:
                raise ValueError("Number of days cannot be negative")
            c.execute("SELECT salary FROM employee_salary WHERE emp_id = ?", (emp_id,))
            current_salary = c.fetchone()
            if current_salary:
                reduction = days * 100
                new_salary = max(0, current_salary[0] - reduction)
                c.execute("UPDATE employee_salary SET salary = ? WHERE emp_id = ?", (new_salary, emp_id))
                conn.commit()
                messagebox.showinfo("Success",
                                    f"Salary reduced successfully!\n"
                                    f"Reduction: {reduction}rs\n"
                                    f"New Salary: {new_salary:.2f}rs")
                emp_id_entry.delete(0, tk.END)
                emp_name_entry.config(state='normal')
                emp_name_entry.delete(0, tk.END)
                emp_name_entry.config(state='disabled')
                days_entry.delete(0, tk.END)
                current_salary_label.config(text="Current Salary: Not Available")
            else:
                messagebox.showerror("Error", "Employee not found")
        except ValueError as e:
            messagebox.showerror("Error", str(e) if str(
                e) != "Number of days cannot be negative" else "Please enter valid numeric data")
        except Exception as e:
            messagebox.showerror("Error", str(e))

    button_frame = tk.Frame(main_frame, bg='#f0f0f0')
    button_frame.pack(pady=20)

    update_btn = tk.Button(button_frame, text="Update",
                           command=reduce_salary,
                           bg='#4CAF50',
                           fg='white',
                           font=("Arial", 11, "bold"),
                           width=12,
                           bd=0,
                           relief="flat",
                           cursor="hand2")
    update_btn.grid(row=0, column=0, padx=10)

    back_btn = tk.Button(button_frame, text="Back to Home",
                         command=lambda: back_to_home(reduce_window),
                         bg='#2196F3',
                         fg='white',
                         font=("Arial", 11, "bold"),
                         width=12,
                         bd=0,
                         relief="flat",
                         cursor="hand2")
    back_btn.grid(row=0, column=1, padx=10)

    update_btn.bind("<Enter>", lambda e: update_btn.configure(bg='#45a049'))
    update_btn.bind("<Leave>", lambda e: update_btn.configure(bg='#4CAF50'))
    back_btn.bind("<Enter>", lambda e: back_btn.configure(bg='#1976D2'))
    back_btn.bind("<Leave>", lambda e: back_btn.configure(bg='#2196F3'))

    reduce_window.protocol("WM_DELETE_WINDOW", on_closing)
    reduce_window.mainloop()


# Function to generate a report
def open_report_module(parent_window):
    parent_window.destroy()
    report_window = tk.Tk()
    report_window.title("Generate Report Module")
    report_window.geometry("400x300")
    report_window.configure(bg='#f0f0f0')

    main_frame = tk.Frame(report_window, bg='#f0f0f0', padx=20, pady=20)
    main_frame.pack(expand=True)

    tk.Label(main_frame, text="Employee Salary Report",
             font=("Arial", 18, "bold"),
             bg='#f0f0f0',
             fg='#333333').pack(pady=(0, 20))

    def generate_report():
        c.execute("SELECT * FROM employee_salary ORDER BY emp_id")
        employees = c.fetchall()
        report = "\n".join([f"ID: {emp[0]}, Name: {emp[1]}, Salary: {emp[2]:.2f}rs" for emp in employees])
        messagebox.showinfo("Employee Report", report if report else "No employee data found")

    button_frame = tk.Frame(main_frame, bg='#f0f0f0')
    button_frame.pack(pady=20)

    report_btn = tk.Button(button_frame, text="Generate Report",
                           command=generate_report,
                           bg='#4CAF50',
                           fg='white',
                           font=("Arial", 11, "bold"),
                           width=12,
                           bd=0,
                           relief="flat",
                           cursor="hand2")
    report_btn.grid(row=0, column=0, padx=10)

    back_btn = tk.Button(button_frame, text="Back to Home",
                         command=lambda: back_to_home(report_window),
                         bg='#2196F3',
                         fg='white',
                         font=("Arial", 11, "bold"),
                         width=12,
                         bd=0,
                         relief="flat",
                         cursor="hand2")
    back_btn.grid(row=0, column=1, padx=10)

    report_btn.bind("<Enter>", lambda e: report_btn.configure(bg='#45a049'))
    report_btn.bind("<Leave>", lambda e: report_btn.configure(bg='#4CAF50'))
    back_btn.bind("<Enter>", lambda e: back_btn.configure(bg='#1976D2'))
    back_btn.bind("<Leave>", lambda e: back_btn.configure(bg='#2196F3'))

    report_window.protocol("WM_DELETE_WINDOW", on_closing)
    report_window.mainloop()


# Function to plot employee salaries
def open_salary_plot_module(parent_window):
    parent_window.destroy()
    c.execute("SELECT name, salary FROM employee_salary")
    data = c.fetchall()
    if not data:
        messagebox.showerror("Error", "No salary data found")
        create_home_page()
        return

    names, salaries = zip(*data)
    plt.figure(figsize=(10, 6))
    plt.bar(names, salaries, color='#4CAF50')
    plt.xlabel('Employees')
    plt.ylabel('Salary (rs)')
    plt.title('Employee Salary Distribution')
    plt.xticks(rotation=45)
    plt.tight_layout()
    plt.show()

    plot_window = tk.Tk()
    plot_window.title("Employee Salary Plot")
    plot_window.geometry("400x200")
    plot_window.configure(bg='#f0f0f0')

    main_frame = tk.Frame(plot_window, bg='#f0f0f0', padx=20, pady=20)
    main_frame.pack(expand=True)

    back_btn = tk.Button(main_frame, text="Back to Home",
                         command=lambda: back_to_home(plot_window),
                         bg='#2196F3',
                         fg='white',
                         font=("Arial", 11, "bold"),
                         width=12,
                         bd=0,
                         relief="flat",
                         cursor="hand2")
    back_btn.pack(pady=20)
    back_btn.bind("<Enter>", lambda e: back_btn.configure(bg='#1976D2'))
    back_btn.bind("<Leave>", lambda e: back_btn.configure(bg='#2196F3'))

    plot_window.protocol("WM_DELETE_WINDOW", on_closing)
    plot_window.mainloop()


# Function to view the employee list with delete option
def open_view_employee_list_module(parent_window):
    parent_window.destroy()
    view_window = tk.Tk()
    view_window.title("View Employee List")
    view_window.geometry("500x450")
    view_window.configure(bg='#f0f0f0')

    main_frame = tk.Frame(view_window, bg='#f0f0f0', padx=20, pady=20)
    main_frame.pack(expand=True, fill="both")

    tk.Label(main_frame, text="Employee List",
             font=("Arial", 18, "bold"),
             bg='#f0f0f0',
             fg='#333333').pack(pady=(0, 20))

    tree = ttk.Treeview(main_frame, columns=("ID", "Name", "Salary"), show='headings')
    tree.heading("ID", text="Employee ID")
    tree.heading("Name", text="Employee Name")
    tree.heading("Salary", text="Salary")
    tree.column("ID", width=100)
    tree.column("Name", width=200)
    tree.column("Salary", width=150)
    tree.pack(pady=20, fill="both", expand=True)

    def refresh_tree():
        for row in tree.get_children():
            tree.delete(row)
        c.execute("SELECT * FROM employee_salary ORDER BY emp_id")
        for emp in c.fetchall():
            tree.insert('', 'end', values=(emp[0], emp[1], f"{emp[2]:.2f}rs"))

    def delete_employee():
        selected_item = tree.selection()
        if not selected_item:
            messagebox.showwarning("Warning", "Please select an employee to delete")
            return
        emp_id = tree.item(selected_item)["values"][0]
        if messagebox.askyesno("Confirm", "Are you sure you want to delete this employee?"):
            c.execute("DELETE FROM employee_salary WHERE emp_id = ?", (emp_id,))
            conn.commit()
            messagebox.showinfo("Success", "Employee deleted successfully!")
            refresh_tree()

    refresh_tree()

    button_frame = tk.Frame(main_frame, bg='#f0f0f0')
    button_frame.pack(pady=20)

    delete_btn = tk.Button(button_frame, text="Delete Selected",
                           command=delete_employee,
                           bg='#f44336',
                           fg='white',
                           font=("Arial", 11, "bold"),
                           width=12,
                           bd=0,
                           relief="flat",
                           cursor="hand2")
    delete_btn.grid(row=0, column=0, padx=10)

    back_btn = tk.Button(button_frame, text="Back to Home",
                         command=lambda: back_to_home(view_window),
                         bg='#2196F3',
                         fg='white',
                         font=("Arial", 11, "bold"),
                         width=12,
                         bd=0,
                         relief="flat",
                         cursor="hand2")
    back_btn.grid(row=0, column=1, padx=10)

    delete_btn.bind("<Enter>", lambda e: delete_btn.configure(bg='#d32f2f'))
    delete_btn.bind("<Leave>", lambda e: delete_btn.configure(bg='#f44336'))
    back_btn.bind("<Enter>", lambda e: back_btn.configure(bg='#1976D2'))
    back_btn.bind("<Leave>", lambda e: back_btn.configure(bg='#2196F3'))

    view_window.protocol("WM_DELETE_WINDOW", on_closing)
    view_window.mainloop()


# Function to go back to the home page
def back_to_home(current_window):
    current_window.destroy()
    create_home_page()


# Function to create the home page
def create_home_page():
    home_page = tk.Tk()
    home_page.title("Employee Salary Management")
    home_page.geometry("400x500")
    home_page.configure(bg='#f0f0f0')

    tk.Label(home_page, text="Employee Salary Management System",
             font=("Arial", 20, "bold"),
             bg='#f0f0f0',
             fg='#333333',
             wraplength=350).pack(pady=20)

    button_style = {"font": ("Arial", 11, "bold"),
                    "width": 25,
                    "height": 2,
                    "bd": 0,
                    "bg": '#2196F3',
                    "fg": 'white',
                    "relief": "flat",
                    "cursor": "hand2"}

    buttons = [
        ("Add Employee Salary", lambda: open_employee_salary_module(home_page)),
        ("Salary Increment/Update", lambda: open_salary_update_module(home_page)),
        ("Salary Search & Filter", lambda: open_salary_search_module(home_page)),
        ("Reduce Salary", lambda: open_reduce_salary_module(home_page)),
        ("Generate Report", lambda: open_report_module(home_page)),
        ("Plot Salary", lambda: open_salary_plot_module(home_page)),
        ("View Employee List", lambda: open_view_employee_list_module(home_page))
    ]

    for text, command in buttons:
        btn = tk.Button(home_page, text=text, command=command, **button_style)
        btn.pack(pady=10)
        btn.bind("<Enter>", lambda e, b=btn: b.configure(bg='#1976D2'))
        btn.bind("<Leave>", lambda e, b=btn: b.configure(bg='#2196F3'))

    home_page.protocol("WM_DELETE_WINDOW", on_closing)
    home_page.mainloop()


# Function to handle application closing
def on_closing():
    if messagebox.askokcancel("Quit", "Do you want to quit?"):
        conn.close()
        # Check if admin_login_window exists and is not already destroyed
        global admin_login_window
        if admin_login_window and tk.Tk.winfo_exists(admin_login_window):
            admin_login_window.destroy()
            admin_login_window = None
        # Check if the root window exists before destroying
        if tk._default_root and tk.Tk.winfo_exists(tk._default_root):
            tk._default_root.destroy()


# Start the application
if __name__ == "__main__":
    open_admin_login()