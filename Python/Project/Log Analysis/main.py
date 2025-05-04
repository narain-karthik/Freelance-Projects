import re
from datetime import datetime
import random  # Corrected import

import pandas as pd
import matplotlib
from reportlab.lib.styles import getSampleStyleSheet

matplotlib.use('Agg')  # Fix for Matplotlib GUI issues
import matplotlib.pyplot as plt
import seaborn as sns
from collections import Counter
import json
import os
from flask import Flask, render_template, jsonify, send_file
from reportlab.pdfgen import canvas
from reportlab.lib.pagesizes import letter
from reportlab.lib import colors
from reportlab.platypus import SimpleDocTemplate, Table, TableStyle, Image, Paragraph, Spacer, PageBreak

app = Flask(__name__)

# Define log file path
LOG_FILE = "access.log"

# Regular expression to parse Apache log format
LOG_PATTERN = r'(\d+\.\d+\.\d+\.\d+) - - \[(.*?)\] \"(.*?)\" (\d+) (\d+|-)'

LOG_CSV = "static/log_analysis_report.csv"
LOG_JSON = "static/log_analysis_report.json"


# Read and parse log file
def parse_logs():
    ip_list, timestamp_list, request_list, status_list, size_list = [], [], [], [], []

    if not os.path.exists(LOG_FILE):
        print(f"Log file {LOG_FILE} not found!")
        return None

    with open(LOG_FILE, "r") as file:
        for line in file:
            match = re.match(LOG_PATTERN, line)
            if match:
                ip, timestamp, request, status, size = match.groups()
                ip_list.append(ip)
                timestamp_list.append(timestamp)
                request_list.append(request)
                status_list.append(status)
                size_list.append(size if size != '-' else '0')

    if not ip_list:
        print("Log file is empty or has no matching entries.")
        return None

    df = pd.DataFrame({
        "IP": ip_list,
        "Timestamp": timestamp_list,
        "Request": request_list,
        "Status": status_list,
        "Size": size_list
    })

    return df


# Analyze logs
def analyze_logs():
    df = parse_logs()
    if df is None:
        return None

    df.to_csv(LOG_CSV, index=False)
    df.to_json(LOG_JSON, orient="records")
    return df


# Detect security threats
def detect_security_issues(df):
    brute_force_attempts = df[df['Request'].str.contains("login") & df['Status'].astype(int) == 401]
    return brute_force_attempts["IP"].value_counts().head().to_dict()


# Traffic visualization
def visualize_traffic(df):
    df["Status"] = pd.to_numeric(df["Status"], errors="coerce")  # Convert Status to numeric
    df = df.dropna(subset=["Status"])  # Drop any rows where Status couldn't be converted

    plt.figure(figsize=(10, 5))
    sns.countplot(y=df["Status"].astype(int), order=df["Status"].astype(int).value_counts().index, palette="coolwarm")
    plt.title("HTTP Status Codes Frequency")
    plt.xlabel("Count")
    plt.ylabel("Status Code")
    plt.savefig("static/status_codes.png")
    plt.close()




@app.route('/')
def dashboard():
    df = analyze_logs()

    if df is None:
        return "Log file is empty or not found!", 404

    visualize_traffic(df)

    top_ips = df["IP"].value_counts().head(5).to_dict()
    error_counts = df[df["Status"].astype(int) >= 400]["Status"].value_counts().to_dict()
    security_issues = detect_security_issues(df)

    return render_template("dashboard.html", top_ips=top_ips, error_counts=error_counts,
                           security_issues=security_issues)


@app.route('/traffic_analysis_page')
def traffic_analysis():
    return render_template('traffic_analysis.html')  # Ensure this file exists


@app.route('/download/<filetype>')
def download_report(filetype):
    if filetype == "csv":
        return send_file(LOG_CSV, as_attachment=True)
    elif filetype == "json":
        return send_file(LOG_JSON, as_attachment=True)
    else:
        return "Invalid file type!", 400

@app.route('/error_logs_page')
def error_logs_page():
    return render_template('error_logs.html')

@app.route('/api/data')
def api_data():
    df = analyze_logs()
    if df is None:
        return jsonify([])
    return jsonify(df.to_dict(orient='records'))


@app.route('/api/traffic_chart')
def traffic_chart():
    data = {
        "labels": ["200 OK", "404 Not Found", "500 Server Error", "403 Forbidden"],
        "values": [1500, 300, 200, 100]
    }
    return jsonify(data)

# Function to parse logs and filter errors
def get_error_logs():
    error_logs = []
    with open(LOG_FILE, "r") as file:
        for line in file:
            match = re.match(r'(\d+\.\d+\.\d+\.\d+) - - \[(.*?)\] "(.*?)" (\d+) .* "(.*?)" "(.*?)"', line)
            if match:
                ip, timestamp, request, status, referrer, user_agent = match.groups()
                status_code = int(status)

                # Filter only error logs (4xx and 5xx status codes)
                if status_code >= 400:
                    error_logs.append({
                        "ip": ip,
                        "timestamp": timestamp,
                        "request": request,
                        "status": status,
                        "user_agent": user_agent,
                        "referrer": referrer
                    })

    return error_logs


@app.route("/api/error_logs")
def error_logs():
    return jsonify(get_error_logs())


@app.route('/download/csv')
def download_csv():
    return send_file(LOG_CSV, as_attachment=True) if os.path.exists(LOG_CSV) else "File not found", 404


@app.route('/download/json')
def download_json():
    return send_file(LOG_JSON, as_attachment=True) if os.path.exists(LOG_JSON) else "File not found", 404


@app.route('/download/pdf')
def download_pdf():
    pdf_file = "static/traffic_report.pdf"
    doc = SimpleDocTemplate(pdf_file, pagesize=letter)
    elements = []
    styles = getSampleStyleSheet()

    # Title
    elements.append(Paragraph("Traffic Analysis Report", styles["Title"]))
    elements.append(Paragraph("Generated on: " + datetime.now().strftime("%Y-%m-%d %H:%M:%S"), styles["Normal"]))
    elements.append(Spacer(1, 12))

    # Generate and add live traffic graph
    generate_live_traffic_graph()
    live_traffic_graph_path = "static/live_traffic.png"

    if os.path.exists(live_traffic_graph_path):
        elements.append(Paragraph("Graph: Live Traffic Monitoring - Status Codes", styles["Heading2"]))
        elements.append(Image(live_traffic_graph_path, width=400, height=300))
        elements.append(Spacer(1, 12))

    # --- PAGE BREAK (New Page for Full Live Traffic Analysis) ---
    elements.append(PageBreak())

    # Live Traffic Analysis Full Report (NEW PAGE)
    elements.append(Paragraph("Live Traffic Analysis - Full Report", styles["Title"]))
    elements.append(Spacer(1, 12))

    # Live Traffic Monitoring Table
    elements.append(Paragraph("Live Traffic Monitoring Details", styles["Heading2"]))

    traffic_data = get_live_traffic()
    table_data = [["IP Address", "Timestamp", "Request", "Status", "Size", "User-Agent", "Referrer"]]

    for log in traffic_data:
        table_data.append([log["IP"], log["Timestamp"], log["Request"], log["Status"], log["Size"], log["User-Agent"],
                           log["Referrer"]])

    traffic_table = Table(table_data)
    traffic_table.setStyle(TableStyle([
        ('BACKGROUND', (0, 0), (-1, 0), colors.darkblue),
        ('TEXTCOLOR', (0, 0), (-1, 0), colors.whitesmoke),
        ('ALIGN', (0, 0), (-1, -1), 'CENTER'),
        ('FONTNAME', (0, 0), (-1, 0), 'Helvetica-Bold'),
        ('BOTTOMPADDING', (0, 0), (-1, 0), 12),
        ('BACKGROUND', (0, 1), (-1, -1), colors.lightgrey),
        ('GRID', (0, 0), (-1, -1), 1, colors.black)
    ]))

    elements.append(traffic_table)
    elements.append(Spacer(1, 12))

    # Build PDF
    doc.build(elements)

    return send_file(pdf_file, as_attachment=True)


# Simulated live traffic data
def get_live_traffic():
    return [
        {
            "IP": f"192.168.1.{random.randint(1, 100)}",
            "Timestamp": datetime.now().strftime("%Y-%m-%d %H:%M:%S"),
            "Request": random.choice(["GET /home", "POST /login", "GET /about"]),
            "Status": random.choice([200, 404, 500]),
            "Size": random.randint(100, 1000)
        }
        for _ in range(5)  # Simulating 5 requests
    ]
def generate_live_traffic_graph():
    # Example data (Replace this with your actual log data)
    data = pd.DataFrame({
        "Status": ["200", "404", "500", "302", "200", "403", "200", "404", "500", "302", "200"],
    })

    # Generate the plot
    plt.figure(figsize=(8, 5))
    sns.countplot(y=data["Status"], order=data["Status"].value_counts().index, palette="coolwarm")

    plt.title("Live Traffic Monitoring - Status Codes")
    plt.xlabel("Count")
    plt.ylabel("HTTP Status Code")

    # Save the graph
    plt.savefig("static/live_traffic.png")
    plt.close()

@app.route('/api/live_traffic')
def live_traffic():
    return jsonify(get_live_traffic())


def get_live_traffic():
    return [
        {"IP": "192.168.1.1", "Timestamp": "2025-02-22 15:00:01", "Request": "GET /home", "Status": "200", "Size": "1024", "User-Agent": "Mozilla/5.0", "Referrer": "https://example.com"},
        {"IP": "192.168.1.2", "Timestamp": "2025-02-22 15:00:02", "Request": "POST /login", "Status": "403", "Size": "512", "User-Agent": "Chrome/89.0", "Referrer": "https://example.com/login"},
        {"IP": "192.168.1.3", "Timestamp": "2025-02-22 15:00:03", "Request": "GET /dashboard", "Status": "500", "Size": "2048", "User-Agent": "Firefox/85.0", "Referrer": "https://example.com/dashboard"},
    ]


@app.route('/live_traffic_analysis')
def live_traffic_analysis():
    return render_template('live_traffic_analysis.html')


# Patterns for detecting security threats
THREAT_PATTERNS = {
    "SQL Injection": r"(\bUNION\b|\bSELECT\b|\bINSERT\b|\bUPDATE\b|\bDELETE\b|[';])",
    "XSS Attack": r"(<script>|javascript:|onerror=|alert\()",
    "Brute Force": r"(Failed Login|Invalid Password|Too Many Attempts)"
}


@app.route('/api/security_threats', methods=['GET'])
def get_security_threats():
    try:
        # Example threat data (Replace this with real data)
        security_threats = [
            {"ip": "192.168.1.10", "threat_type": "SQL Injection", "request": "/login?user=admin'--",
             "user_agent": "Mozilla/5.0"},
            {"ip": "192.168.1.20", "threat_type": "XSS Attack", "request": "/search?q=<script>alert(1)</script>",
             "user_agent": "Chrome"},
        ]

        return jsonify(security_threats), 200  # Return JSON response
    except Exception as e:
        return jsonify({"error": str(e)}), 500  # Return error if something goes wrong

@app.route('/security_threats')
def security_threats():
    return render_template('security_threats.html')

if __name__ == "__main__":
    app.run(debug=True)
