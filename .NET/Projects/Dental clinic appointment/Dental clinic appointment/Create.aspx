<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Create.aspx.vb" Inherits="Dental_clinic_appointment.Create" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Registration Page</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #fafafa; /* Updated to soft yellow background */
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }

        .registration-container {
            background-color: white;
            padding: 30px;
            border-radius: 12px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            width: 360px;
            max-width: 100%;
        }

        .logo {
            text-align: center;
            margin-bottom: 20px;
        }

        .logo img {
            max-width: 120px; /* Adjust logo size */
        }

        .form-group {
            margin-bottom: 20px;
        }

        label {
            display: block;
            margin-bottom: 8px;
            color: #333;
            font-weight: 600;
        }

        input[type="text"],
        input[type="tel"],
        input[type="email"],
        input[type="password"] {
            width: 100%;
            padding: 12px;
            border: 1px solid #f8a5a5; /* Light red border */
            border-radius: 8px;
            box-sizing: border-box;
            background-color: #fff1f1; /* Light red background */
            font-size: 16px;
            color: #333;
        }

        input[type="text"]:focus,
        input[type="tel"]:focus,
        input[type="email"]:focus,
        input[type="password"]:focus {
            border-color: #f27979; /* Darker red focus */
            outline: none;
        }

        button {
            background-color: #f27474; /* Light red button */
            color: white;
            padding: 12px;
            border: none;
            border-radius: 8px;
            cursor: pointer;
            width: 100%;
            font-size: 16px;
        }

        button:hover {
            background-color: #f26363; /* Darker red on hover */
        }

        .bottom-links {
            text-align: center;
            margin-top: 20px;
            font-size: 14px;
            color: #777;
        }

        .bottom-links a {
            color: #d9534f; /* Red link color */
            text-decoration: none;
            font-weight: bold;
        }

        .bottom-links a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="registration-container">
            <div class="logo">
                <img src="dental.png" alt="Logo">
            </div>
            <div class="form-group">
                <label for="txtName">Name</label>
                <asp:TextBox runat="server" ID="txtName" CssClass="aspInput" required="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPhone">Phone</label>
                <asp:TextBox runat="server" ID="txtPhone" CssClass="aspInput" required="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtEmail">Email</label>
                <asp:TextBox runat="server" ID="txtEmail" CssClass="aspInput" required="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPassword">Password</label>
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="aspInput" required="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtConfirmPassword">Confirm Password</label>
                <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" CssClass="aspInput" required="true"></asp:TextBox>
            </div>
            <asp:Button runat="server" ID="btnRegister" Text="Register" CssClass="btn" />
            <div class="bottom-links">
                By continuing, you agree to Dairy's Conditions of Use and Privacy Notice
                <br />
                Already registered? <a href="login.aspx">Login</a>
            </div>
        </div>
    </form>
</body>
</html>
