<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Contact.aspx.vb" Inherits="Driving_School_Information_System.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f9f9f9;
        }

        .contact-container {
            max-width: 900px;
            margin: 0 auto;
            padding: 20px;
            background: #ffffff;
            box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
        }

        .contact-header {
            text-align: center;
            margin-bottom: 20px;
        }

        .contact-header h1 {
            color: #333333;
            font-size: 32px;
            margin-bottom: 10px;
        }

        .contact-header p {
            color: #666666;
            font-size: 16px;
        }

        .form-section, .info-section {
            display: flex;
            flex-direction: column;
            gap: 15px;
        }

        .form-section {
            margin-top: 20px;
        }

        .form-section input, .form-section textarea {
            width: 100%;
            padding: 10px;
            border: 1px solid #cccccc;
            border-radius: 5px;
            font-size: 16px;
        }

        .form-section button {
            width: 100%;
            padding: 12px;
            background-color: #007BFF;
            color: white;
            border: none;
            border-radius: 5px;
            font-size: 18px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .form-section button:hover {
            background-color: #0056b3;
        }

        .info-section {
            margin-top: 20px;
            background-color: #f4f4f4;
            padding: 15px;
            border-radius: 5px;
        }

        .info-item {
            display: flex;
            align-items: center;
            gap: 10px;
        }

        .info-item img {
            height: 40px;
            width: 40px;
        }

        .info-item span {
            font-size: 16px;
            color: #333333;
        }

        @media (max-width: 768px) {
            .contact-container {
                padding: 10px;
            }

            .form-section button {
                font-size: 16px;
            }
        }
    </style>

    <div class="contact-container">
        <div class="contact-header">
            <h1>Contact Us</h1>
            <p>If you want to ask a question, send a message, or submit a testimonial, please use the form below.</p>
        </div>

        <div class="form-section">
            <asp:TextBox ID="NameTextBox" runat="server" placeholder="Your Name" />
            <asp:TextBox ID="EmailTextBox" runat="server" placeholder="Your Email" />
            <asp:TextBox ID="PhoneTextBox" runat="server" placeholder="Your Phone Number" />
            <asp:TextBox ID="MessageTextBox" runat="server" TextMode="MultiLine" placeholder="Your Message" Height="150px" />
            <asp:Button ID="SendButton" runat="server" Text="Send Message" OnClick="SendButton_Click" />
        </div>

        <div class="info-section">
            <div class="info-item">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/Contact/pin.png" />
                <span>Address: 32145 Coimbatore</span>
            </div>
            <div class="info-item">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Image/Contact/phone-call.png" />
                <span>Phone Number: 87545999666</span>
            </div>
            <div class="info-item">
                <asp:Image ID="Image3" runat="server" ImageUrl="~/Image/Contact/back-in-time.png" />
                <span>Operating Hours: Mon-Fri 9 AM - 5 PM, Sat-Sun 11 AM - 4 PM</span>
            </div>
        </div>
    </div>
</asp:Content>
