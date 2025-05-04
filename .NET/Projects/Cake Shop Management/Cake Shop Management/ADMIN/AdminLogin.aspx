<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AdminLogin.aspx.vb" Inherits="Cake_Shop_Management.AdminLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Login Page</title>
    <!-- Google Font -->
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;500;700&display=swap" rel="stylesheet">
    <!-- Bootstrap CDN for responsive design -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            font-family: 'Roboto', sans-serif;
            background-color: #f2f4f8;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .login-container {
            background-color: #fff;
            padding: 30px;
            border-radius: 12px;
            box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);
            width: 100%;
            max-width: 400px;
        }
        .login-container h2 {
            font-weight: 700;
            color: #4caf50;
            margin-bottom: 25px;
            text-align: center;
        }
        .form-label {
            font-weight: 500;
        }
        .form-control {
            border-radius: 8px;
            padding: 10px;
            font-size: 16px;
            margin-bottom: 15px;
        }
        .btn-login {
            background-color: #4caf50;
            color: white;
            width: 100%;
            padding: 12px;
            font-size: 16px;
            border-radius: 8px;
            font-weight: 600;
            border: none;
        }
        .btn-login:hover {
            background-color: #388e3c;
            cursor: pointer;
        }
        .error-message {
            color: red;
            text-align: center;
            margin-top: 10px;
        }
        .dashboard {
            display: none;
            margin-top: 20px;
            border: 1px solid #ccc;
            padding: 15px;
            background-color: #f9f9f9;
        }
        .panel-title {
            color: #4caf50;
            font-weight: 600;
        }
         .logo {
            text-align: center;
            margin-bottom: 20px;
        }

        .logo img {
            max-width: 120px; /* Adjust logo size */
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h2>&nbsp;</h2>
            <h2>
                <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl="~/logo/cake.png" 
                    Width="200px" />
            </h2>
            <h2>Login to Admin Panel</h2>

            <label for="txtUsername" class="form-label">Username:</label>
            <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control"></asp:TextBox>

            <label for="txtPassword" class="form-label">Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>

            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="btn-login" />

            <asp:Label ID="lblMessage" runat="server" CssClass="error-message"></asp:Label>

            <!-- Admin and Chief Panels (hidden initially) -->
            <asp:Panel ID="pnlAdmin" runat="server" CssClass="dashboard" Visible="False">
                <h3 class="panel-title">Admin Dashboard</h3>
                <p>Welcome to the admin panel. Here you can manage users, settings, and more.</p>
            </asp:Panel>

            <asp:Panel ID="pnlChief" runat="server" CssClass="dashboard" Visible="False">
                <h3 class="panel-title">Chief Dashboard</h3>
                <p>Welcome to the chief panel. Here you can review reports, assign tasks, and monitor progress.</p>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
