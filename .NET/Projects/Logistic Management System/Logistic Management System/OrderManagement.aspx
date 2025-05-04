<%@ Page Title="Order Management - Logistic Management System" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="OrderManagement.aspx.vb" Inherits="Logistic_Management_System.OrderManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .order-container {
            padding: 20px;
        }
        .order-container h2 {
            color: #2c3e50;
            margin-bottom: 20px;
        }
        .grid-view {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }
        .grid-view th, .grid-view td {
            border: 1px solid #ddd;
            padding: 10px;
            text-align: left;
        }
        .grid-view th {
            background-color: #34495e;
            color: white;
        }
        .grid-view tr:nth-child(even) {
            background-color: #f9f9f9;
        }
        .grid-view tr:hover {
            background-color: #ecf0f1;
        }
        .button-panel {
            margin-top: 20px;
        }
        .create-order-form {
            margin: 20px 0;
            padding: 15px;
            background-color: #ecf0f1;
            border-radius: 5px;
        }
        .create-order-form label {
            display: inline-block;
            width: 120px;
            font-weight: bold;
        }
        .create-order-form input, .create-order-form select {
            margin-bottom: 10px;
            padding: 5px;
            width: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="order-container">
        <h2>Order Management</h2>
        <p>View, manage, and create orders in real-time.</p>

        <!-- Create Order Form -->
        <div class="create-order-form">
            <h3>Create New Order</h3>
            <div>
                <label for="txtCustomerName">Customer Name:</label>
                <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="ddlStatus">Status:</label>
                <asp:DropDownList ID="ddlStatus" runat="server">
                    <asp:ListItem Text="Pending" Value="Pending"></asp:ListItem>
                    <asp:ListItem Text="Processing" Value="Processing"></asp:ListItem>
                    <asp:ListItem Text="Shipped" Value="Shipped"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <asp:Button ID="btnCreateOrder" runat="server" Text="Create Order" OnClick="btnCreateOrder_Click" />
            </div>
            <asp:Label ID="CreateStatusLabel" runat="server" ForeColor="Green" Visible="False"></asp:Label>
        </div>

        <!-- GridView to display orders -->
        <asp:GridView ID="OrderGridView" runat="server" AutoGenerateColumns="False" CssClass="grid-view" 
            DataKeyNames="OrderID" OnRowCommand="OrderGridView_RowCommand">
            <Columns>
                <asp:BoundField DataField="OrderID" HeaderText="Order ID" />
                <asp:BoundField DataField="CustomerName" HeaderText="Customer" />
                <asp:BoundField DataField="OrderDate" HeaderText="Order Date" DataFormatString="{0:MM/dd/yyyy}" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:ButtonField ButtonType="Button" Text="Update Status" CommandName="UpdateStatus" />
            </Columns>
        </asp:GridView>

        <!-- Button panel for additional actions -->
        <div class="button-panel">
            <asp:Button ID="RefreshButton" runat="server" Text="Refresh Orders" OnClick="RefreshButton_Click" />
            <asp:Label ID="StatusLabel" runat="server" ForeColor="Green" Visible="False"></asp:Label>
        </div>
    </div>
</asp:Content>