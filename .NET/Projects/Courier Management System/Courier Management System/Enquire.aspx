<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Enquire.aspx.vb" Inherits="Courier_Management_System.Enquire" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* Form section styles with light red background */
        .form-section {
            background-color: #ffcccc; /* Light red background */
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1); /* Subtle shadow */
            max-width: 500px;
            margin: 0 auto; /* Center the form */
        }

        /* Flexbox layout for labels and inputs */
        .form-group {
            display: flex;
            align-items: center;
            margin-bottom: 15px;
        }

        /* Label styles */
        .form-group label {
            width: 150px;
            font-weight: bold;
            color: #333;
        }

        /* Input and textarea styles */
        .form-section input,
        .form-section textarea {
            width: 100%;
            padding: 10px;
            margin: 5px 0;
            border: 1px solid #ddd;
            border-radius: 5px;
            font-size: 1em;
            background-color: #fff; /* White background for inputs */
        }

        .form-section textarea {
            resize: vertical; /* Allow vertical resizing */
        }

        .form-section input.medium,
        .form-section textarea.medium {
            width: 70%; /* Medium-sized input fields */
        }

        .form-section input:focus,
        .form-section textarea:focus {
            border-color: #ff6600; /* Focus border color to match the theme */
        }

        .form-section button {
            background-color: #ff6600; /* Orange button */
            color: white;
            padding: 12px 25px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 1.1em;
            transition: background-color 0.3s ease;
            margin-top: 20px;
        }

        .form-section button:hover {
            background-color: #e65c00; /* Darker orange on hover */
        }
        .style1
        {
            text-align: center;
            color: #FF4D4D;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h2 class="style1">Enquriy Form</h2>
    <div class="form-section">
        <div class="form-group">
            <label for="NameTextBox">Your Name</label>
            <asp:TextBox ID="NameTextBox" runat="server" CssClass="medium" placeholder="Your Name" />
        </div>
        <div class="form-group">
            <label for="EmailTextBox">Your Email</label>
            <asp:TextBox ID="EmailTextBox" runat="server" CssClass="medium" placeholder="Your Email" />
        </div>
        <div class="form-group">
            <label for="PhoneTextBox">Your Phone Number</label>
            <asp:TextBox ID="PhoneTextBox" runat="server" CssClass="medium" placeholder="Your Phone Number" />
        </div>
        <div class="form-group">
            <label for="MessageTextBox">Your Message</label>
            <asp:TextBox ID="MessageTextBox" runat="server" CssClass="medium" TextMode="MultiLine" placeholder="Your Message" Height="150px" />
        </div>
        <asp:Button ID="SendButton" runat="server" Text="Send Message" OnClick="SendButton_Click" />
    </div>
</asp:Content>
