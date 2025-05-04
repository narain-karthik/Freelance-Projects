<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Payment.aspx.vb" Inherits="Cake_Shop_Management.Payment" %>

<%@ Import Namespace="Cake_Shop_Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Payment Page</title>
    
    <!-- Custom CSS for Payment Page -->
    <style>
        .payment-page {
            max-width: 1000px;
            margin: 0 auto;
            padding: 20px;
        }

        h1 {
            text-align: center;
            font-size: 2em;
            margin-bottom: 20px;
        }

        .payment-form {
            margin-top: 20px;
        }

        .payment-form label {
            display: block;
            margin-bottom: 8px;
            font-weight: bold;
        }

        .payment-form input, .payment-form select {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            border: 1px solid #ddd;
            border-radius: 5px;
        }

        .payment-methods {
            display: flex;
            justify-content: space-between;
        }

        .btn-submit {
            background-color: #28a745;
            color: white;
            padding: 12px 25px;
            text-decoration: none;
            border-radius: 5px;
            font-size: 1.2em;
            cursor: pointer;
        }

        .btn-submit:hover {
            background-color: #218838;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="payment-page">
        <h1>Payment Information</h1>

        <!-- Customer Information Form -->
        <div class="payment-form">
            <label for="txtName">Full Name</label>
            <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>

            <label for="txtEmail">Email ID</label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>

            <label for="txtAddress">Address</label>
            <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>

            <label for="txtPincode">Pin-code</label>
            <asp:TextBox ID="txtPincode" runat="server" CssClass="form-control"></asp:TextBox>

            <label for="txtPhoneNumber">Phone Number</label>
            <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="form-control"></asp:TextBox>

            <!-- Order Details -->
            <label for="lblOrderDetails">Ordered Product Details</label>
            <asp:Label ID="lblOrderDetails" runat="server"></asp:Label>

            <label for="lblTotalAmount">Total Amount</label>
            <asp:Label ID="lblTotalAmount" runat="server"></asp:Label>

            <!-- Payment Method -->
            <label for="ddlPaymentMethod">Select Payment Method</label>
            <asp:DropDownList ID="ddlPaymentMethod" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlPaymentMethod_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Text="UPI Barcode" Value="UPI"></asp:ListItem>
                <asp:ListItem Text="Card Payment" Value="Card"></asp:ListItem>
            </asp:DropDownList>

            <!-- UPI Payment Details -->
            <div id="upiDetails" runat="server" style="display:none;">
                <label for="txtUPI">UPI ID</label>
                <asp:TextBox ID="txtUPI" runat="server" CssClass="form-control"></asp:TextBox>
                <label for="txtUPIAmount">Amount (₹)</label>
                <asp:TextBox ID="txtUPIAmount" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
            </div>

            <!-- Card Payment Details -->
            <div id="cardDetails" runat="server" style="display:none;">
                <label for="txtCardNumber">Card Number</label>
                <asp:TextBox ID="txtCardNumber" runat="server" CssClass="form-control"></asp:TextBox>

                <label for="txtCardName">Cardholder Name</label>
                <asp:TextBox ID="txtCardName" runat="server" CssClass="form-control"></asp:TextBox>

                <label for="txtCVV">CVV</label>
                <asp:TextBox ID="txtCVV" runat="server" CssClass="form-control"></asp:TextBox>

                <label for="txtExpDate">Expiration Date</label>
                <asp:TextBox ID="txtExpDate" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <!-- Submit Button -->
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn-submit" OnClick="btnSubmit_Click" />
        </div>
    </div>
</asp:Content>