<%@ Page Title="" Language="vb" AutoEventWireup="false" 
    MasterPageFile="~/Site.Master" 
    CodeBehind="Home.aspx.vb" 
    Inherits="Attendance_Management_System.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .welcome-container {
            padding: 2rem;
            text-align: center;
            background: white;
            margin: 2rem auto;
            max-width: 800px;
            border-radius: 8px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }

        .welcome-title {
            color: #2c3e50;
            font-size: 2rem;
            margin-bottom: 1rem;
        }

        .welcome-message {
            color: #666;
            font-size: 1.1rem;
            line-height: 1.5;
        }

        @media (max-width: 768px) {
            .welcome-container {
                margin: 1rem;
                padding: 1.5rem;
            }
        }
        .welcome-image
        {}
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="welcome-container">
        <h1 class="welcome-title">Welcome Admin</h1>
        <p class="welcome-message">
            to the Attendance Management System<br />
            Manage employee attendance efficiently and effectively
        </p>
        <p class="welcome-message">
            &nbsp;</p>
        <p class="welcome-message">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Attendance.jpg" 
                CssClass="welcome-image" Width="700px" Height="300px" />
        </p>
        <p class="welcome-message">
            &nbsp;</p>
        <p class="welcome-message">
            &nbsp;</p>
    </div>
</asp:Content>