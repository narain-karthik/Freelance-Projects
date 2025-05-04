<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Contact.aspx.vb" Inherits="Catering_Management_System.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* Global Styles */
        body {
            font-family: 'Arial', sans-serif;
            background-color: #f7f7f7;
            color: #333;
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 1000px;
            margin: 40px auto;
            padding: 30px;
            background-color: #fff;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
        }
        .header {
            text-align: center;
            margin-bottom: 30px;
        }
        .header h1 {
            font-size: 32px;
            color: #2c3e50;
        }
        .header h2 {
            font-size: 24px;
            color: #2980b9;
        }

        /* Contact Details Section */
        .details {
            background-color: #ecf0f1;
            border-radius: 8px;
            padding: 20px;
        }

        .details h3 {
            font-size: 26px;
            color: #34495e;
            margin-bottom: 15px;
        }

        .contact-details {
            margin-top: 20px;
        }
        .contact-details p {
            margin: 10px 0;
            font-size: 16px;
        }
        .contact-details strong {
            color: #2980b9;
        }

        /* Responsive Design */
        @media (max-width: 768px) {
            .details {
                width: 100%;
            }
        }
        .style1
        {
            text-align: center;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="header">
            <h1>CONTACT US</h1>
            <h2>Get In Touch</h2>
        </div>

        <!-- Contact Details Section -->
        <div class="details">
           <center> <h3>
                <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/contact.png" 
                    Width="150px" />
            </h3></center>
          <center> <h3 class="style1">Catering Services</h3></center> 
            <p>143 Vysial Street Town Hall Coimbatore 641001</p>
            <div class="contact-details">
                <p><strong>Email:</strong>ybasmj74@gmail.com</p>
                <p><strong>Phone:</strong> +91 9585702925</p>
     
            </div>
        </div>
    </div>
</asp:Content>
