<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Booking.aspx.vb" Inherits="Dental_clinic_appointment.Booking" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Dental Appointment Form</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
            background-color: #f8f8f8;
        }
        h2 {
            text-align: center;
        }
        .container {
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            background: #fff;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .form-group {
            margin-bottom: 15px;
        }
        label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }
        input, select, textarea {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 3px;
            box-sizing: border-box;
        }
        select[multiple] {
            height: 100px;
        }
        button {
            background-color: #4CAF50;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 3px;
            cursor: pointer;
            width: 100%;
        }
        button:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>MAKE AN APPOINTMENT</h2>
        <div class="container">
            <div class="form-group">
                <label for="full_name">Full Name</label>
                <asp:TextBox ID="full_name" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="dob">Date of Birth</label>
                <asp:TextBox ID="dob" runat="server" TextMode="Date"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="address">Address</label>
                <asp:TextBox ID="address" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="state">State</label>
                <asp:DropDownList ID="state" runat="server">
                    <asp:ListItem Value="Andaman and Nicobar Islands">Andaman and Nicobar Islands</asp:ListItem>
                    <asp:ListItem Value="Tamil Nadu">Tamil Nadu</asp:ListItem>
                    <asp:ListItem Value="Kerala">Kerala</asp:ListItem>
                    <asp:ListItem Value="Karnataka">Karnataka</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="email">Email ID</label>
                <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="mobile">Mobile No</label>
                <asp:TextBox ID="mobile" runat="server" TextMode="Phone"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="preferred_datetime">Preferred Date and Time</label>
                <asp:TextBox ID="preferred_datetime" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="reason">Reasons for Appointment</label>
                <asp:ListBox ID="reason" runat="server" SelectionMode="Multiple">
                    <asp:ListItem Value="Cosmetic Dentistry">Cosmetic Dentistry/Teeth whitening or bleaching</asp:ListItem>
                    <asp:ListItem Value="Crowns & Bridges">Crowns & Bridges</asp:ListItem>
                    <asp:ListItem Value="Dental Implants">Dental Implants</asp:ListItem>
                    <asp:ListItem Value="Dentures">Dentures-Partial/Complete</asp:ListItem>
                    <asp:ListItem Value="Extractions">Extractions/Removal of Teeth/Impacted Wisdom Teeth</asp:ListItem>
                    <asp:ListItem Value="Fillings">Fillings</asp:ListItem>
                    <asp:ListItem Value="Others">Others</asp:ListItem>
                    <asp:ListItem Value="Scaling">Scaling/Cleaning and Polishing of Teeth/Gum Treatments</asp:ListItem>
                    <asp:ListItem Value="Single Sitting Root Canal">Single Sitting Root Canal Treatments</asp:ListItem>
                    <asp:ListItem Value="Smile Makeovers">Smile Makeovers</asp:ListItem>
                </asp:ListBox>
            </div>

            <div class="form-group">
                <label for="nature_of_problem">Nature of Dental Problem</label>
                <asp:TextBox ID="nature_of_problem" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="button" />
        </div>
    </form>
</body>
</html>
