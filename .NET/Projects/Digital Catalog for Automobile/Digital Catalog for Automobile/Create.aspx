<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Create.aspx.vb" Inherits="Digital_Catalog_for_Automobile.Create" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Registration Page</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #ffffff; /* White background */
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }

        .registration-container {
            background-color: #ffffff; /* White background for the form */
            padding: 30px;
            border-radius: 12px;
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.1); /* Slightly stronger shadow */
            width: 360px;
            max-width: 100%;
        }

        .logo {
            text-align: center;
            margin-bottom: 25px;
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
            border: 1px solid #ddd;
            border-radius: 8px;
            box-sizing: border-box;
            background-color: #f9f9f9;
            font-size: 16px;
            color: #333;
            transition: border-color 0.3s ease;
        }

        input[type="text"]:focus,
        input[type="tel"]:focus,
        input[type="email"]:focus,
        input[type="password"]:focus {
            border-color: #663399; /* Changed from #4CAF50 (green) to #663399 (purple) */
            outline: none;
            box-shadow: 0 0 5px rgba(102, 51, 153, 0.3); /* Subtle purple glow */
        }

        button {
            background-color: #663399; /* Changed from #4CAF50 (green) to #663399 (purple) */
            color: white;
            padding: 12px;
            border: none;
            border-radius: 8px;
            cursor: pointer;
            width: 100%;
            font-size: 16px;
            font-weight: 600;
            transition: background-color 0.3s ease, transform 0.2s ease;
        }

        button:hover {
            background-color: #552288; /* Darker purple (replaced #45a049) */
            transform: translateY(-2px); /* Slight lift effect */
        }

        .bottom-links {
            text-align: center;
            margin-top: 20px;
            font-size: 14px;
            color: #777;
        }

        .bottom-links a {
            color: #663399; /* Changed to purple for consistency */
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
                <img src="Logo.png" alt="Auto Haven Logo">
            </div>
            <div class="form-group">
                <label for="txtName">Name*</label>
                <asp:TextBox runat="server" ID="txtName" CssClass="aspInput" Placeholder="Enter your full name" Required="True" aria-label="Full Name"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPhone">Phone*</label>
                <asp:TextBox runat="server" ID="txtPhone" CssClass="aspInput" TextMode="Phone" MaxLength="10" Pattern="[0-9]{10}" Placeholder="10-digit number" Required="True" aria-label="Phone Number"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtEmail">Email*</label>
                <asp:TextBox runat="server" ID="txtEmail" CssClass="aspInput" TextMode="Email" Placeholder="example@domain.com" Required="True" aria-label="Email Address"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPassword">Password*</label>
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="aspInput" Placeholder="Enter password" Required="True" aria-label="Password"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtConfirmPassword">Confirm Password*</label>
                <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" CssClass="aspInput" Placeholder="Confirm password" Required="True" aria-label="Confirm Password"></asp:TextBox>
            </div>
            <asp:Button runat="server" ID="btnRegister" Text="Register" CssClass="btn" OnClick="btnRegister_Click" />
            <div class="bottom-links">
                By continuing, you agree to Auto Haven's Conditions of Use and Privacy Notice
                <br />
                Already registered? <a href="login.aspx">Login</a>
            </div>
        </div>
    </form>
</body>
</html>