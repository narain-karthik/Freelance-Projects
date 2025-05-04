<%@ Page Title="" Language="vb" AutoEventWireup="false" 
    MasterPageFile="~/Site.Master" 
    CodeBehind="AboutUs.aspx.vb" 
    Inherits="Attendance_Management_System.AboutUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .about-container {
            max-width: 800px;
            margin: 2rem auto;
            padding: 2rem;
            background: white;
            border-radius: 8px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }

        .about-header {
            color: #2c3e50;
            font-size: 1.8rem;
            margin-bottom: 1.5rem;
            text-align: center;
        }

        .about-content {
            color: #666;
            font-size: 1.1rem;
            line-height: 1.6;
            margin-bottom: 1rem;
        }

        .about-section {
            margin-bottom: 2rem;
        }

        .highlight {
            font-weight: 600;
            color: #2c3e50;
        }

        @media (max-width: 768px) {
            .about-container {
                margin: 1rem;
                padding: 1.5rem;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="about-container">
        <h2 class="about-header">About Us</h2>
        
        <div class="about-section">
            <p class="about-content">
                Welcome to the <span class="highlight">Attendance Management System</span>, a robust solution designed to streamline employee attendance tracking and management.
            </p>
        </div>

        <div class="about-section">
            <p class="about-content">
                Our system is built to cater to organizations of all sizes, offering features such as:
            </p>
            <ul class="about-content">
                <li>Employee registration and management</li>
                <li>Shift-based attendance tracking (Day/Night)</li>
                <li>Detailed attendance records with status (Present/Absent)</li>
                <li>Comprehensive employee and attendance reporting</li>
            </ul>
        </div>

        <div class="about-section">
            <p class="about-content">
                Developed using <span class="highlight">ASP.NET 4.0</span>, this system ensures reliability, security, and compatibility with existing infrastructure. For support or inquiries, contact us at <span class="highlight">support@attendance-system.com</span>.
            </p>
        </div>
    </div>
</asp:Content>