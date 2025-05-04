<%@ Page Title="Enquiry Form" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Enquiry.aspx.vb" Inherits="Catering_Management_System.Enquiry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* Basic styling */
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f7f6;
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 800px;
            margin: 50px auto;
            padding: 20px;
            background-color: white;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            border-radius: 10px;
        }
        h2 {
            text-align: center;
            color: #333;
        }
        label {
            display: block;
            margin: 10px 0 5px;
            font-weight: bold;
        }
        input[type="text"], select {
            width: 100%;
            padding: 10px;
            margin: 5px 0 15px 0;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
        }
        input[type="text"]:focus, select:focus {
            border-color: #007bff;
            outline: none;
        }
        .submit-btn {
            width: 100%;
            padding: 12px;
            background-color: #007bff;
            border: none;
            border-radius: 5px;
            color: white;
            font-size: 16px;
            cursor: pointer;
            transition: background-color 0.3s;
        }
        .submit-btn:hover {
            background-color: #c19b35;
        }
        .form-group {
            margin-bottom: 15px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Enquiry & Booking Form</h2>
        <form>
            <div class="form-group">
                <label for="NameTextBox">Name:</label>
                <asp:TextBox ID="NameTextBox" runat="server" CssClass="form-control" placeholder="Enter your name"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <label for="EmailIDTextBox">Email ID:</label>
                <asp:TextBox ID="EmailIDTextBox" runat="server" CssClass="form-control" placeholder="Enter your email"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="PhoneNumberTextBox">Phone Number:</label>
                <asp:TextBox ID="PhoneNumberTextBox" runat="server" CssClass="form-control" placeholder="Enter your phone number"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="AddressTextBox">Address:</label>
                <asp:TextBox ID="AddressTextBox" runat="server" CssClass="form-control" placeholder="Enter your address"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="PackageDropDownList">Package:</label>
                <asp:DropDownList ID="PackageDropDownList" runat="server" CssClass="form-control">
                    <asp:ListItem>Birthday Party</asp:ListItem>
                    <asp:ListItem>Wedding Party</asp:ListItem>
                    <asp:ListItem>Retirement Function</asp:ListItem>
                    <asp:ListItem>Corporate Party</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label for="DateTextBox">Event Date:</label>
                <asp:TextBox ID="DateTextBox" runat="server" CssClass="form-control" placeholder="Enter event date" type="date"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" CssClass="submit-btn" />
            </div>
        </form>
    </div>
</asp:Content>
