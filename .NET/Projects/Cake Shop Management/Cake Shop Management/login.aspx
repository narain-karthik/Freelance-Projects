<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="Cake_Shop_Management.login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Login Page</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #ffffff; /* Same light yellow background as the master page */
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }

        .login-container {
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
        input[type="password"] {
            width: 100%;
            padding: 12px;
            border: 1px solid #ddd;
            border-radius: 8px;
            box-sizing: border-box;
            background-color: #f9f9f9;
            font-size: 16px;
            color: #333;
        }

        input[type="text"]:focus,
        input[type="password"]:focus {
            border-color: #4CAF50;
            outline: none;
        }

        .remember-me {
            display: flex;
            align-items: center;
            margin-bottom: 20px;
        }

        .remember-me label {
            margin-left: 8px;
            color: #555;
            font-weight: 400;
        }

        button {
            background-color: #4CAF50;
            color: white;
            padding: 12px;
            border: none;
            border-radius: 8px;
            cursor: pointer;
            width: 100%;
            font-size: 16px;
        }

        button:hover {
            background-color: #45a049;
        }

        .bottom-links {
            text-align: center;
            margin-top: 20px;
            font-size: 14px;
            color: #777;
        }

        .bottom-links a {
            color: #337ab7;
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
        <div class="login-container">
            <div class="logo">
                <img src="logo/cake.png" alt="Logo">
            </div>

            <div class="form-group">
                <label for="txtPhone">Phone</label>
                <asp:TextBox runat="server" ID="txtPhone" CssClass="aspInput" required="true"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtPassword">Password</label>
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="aspInput" required="true"></asp:TextBox>
            </div>

            <div class="remember-me">
                <asp:CheckBox runat="server" ID="chkRememberMe" />
                <label for="chkRememberMe">Remember me</label>
            </div>

            <asp:Button runat="server" ID="btnLogin" Text="Login" CssClass="btn" OnClick="btnLogin_Click" />

            <div class="bottom-links">
                <a href="#">Forgot your password?</a><br />
                New to our cake Shop? <a href="Create.aspx">Create account</a> <br /> <br />
                <a href="ADMIN/AdminLogin.aspx">ADMIN LOGIN</a><br />
               
            </div>
        </div>
    </form>
</body>
</html>
