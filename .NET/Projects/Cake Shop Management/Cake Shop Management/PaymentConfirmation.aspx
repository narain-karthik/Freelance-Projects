<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="PaymentConfirmation.aspx.vb" Inherits="Cake_Shop_Management.PaymentConfirmation" %>
<%@ Import Namespace="Cake_Shop_Management" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Payment Confirmation</title>
    
    <!-- Custom CSS for Confirmation Page -->
    <style>
        .confirmation-page {
            max-width: 1000px;
            margin: 0 auto;
            padding: 20px;
        }

        h1 {
            text-align: center;
            font-size: 2em;
            margin-bottom: 20px;
        }

        .order-details {
            margin-top: 20px;
            font-size: 1.2em;
        }

        .order-details label {
            font-weight: bold;
            display: block;
            margin-top: 10px;
        }

        .btn-home {
            background-color: #007bff;
            color: white;
            padding: 12px 25px;
            text-decoration: none;
            border-radius: 5px;
            font-size: 1.2em;
            cursor: pointer;
        }

        .btn-home:hover {
            background-color: #0056b3;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="confirmation-page">
        <h1>Payment Confirmation</h1>

        <!-- Display Order Details -->
        <div class="order-details">
            <label for="lblFullName">Full Name</label>
            <asp:Label ID="lblFullName" runat="server"></asp:Label>

            <label for="lblEmail">Email ID</label>
            <asp:Label ID="lblEmail" runat="server"></asp:Label>

            <label for="lblAddress">Address</label>
            <asp:Label ID="lblAddress" runat="server"></asp:Label>

            <label for="lblOrderDetails">Ordered Product Details</label>
            <asp:Label ID="lblOrderDetails" runat="server"></asp:Label>

            <label for="lblTotalAmount">Total Amount</label>
            <asp:Label ID="lblTotalAmount" runat="server"></asp:Label>

            <label for="lblPaymentMethod">Payment Method</label>
            <asp:Label ID="lblPaymentMethod" runat="server"></asp:Label>

            <label for="lblPaymentStatus">Payment Status</label>
            <asp:Label ID="lblPaymentStatus" runat="server"></asp:Label>
        </div>

        <!-- Button to return to homepage -->
        <asp:Button ID="btnHome" runat="server" Text="Back to Home" CssClass="btn-home" OnClick="btnHome_Click" />
    </div>
</asp:Content>
