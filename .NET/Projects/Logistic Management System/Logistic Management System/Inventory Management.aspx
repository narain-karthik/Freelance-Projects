<%@ Page Title="Inventory Management - Logistic Management System" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="InventoryManagement.aspx.vb" Inherits="Logistic_Management_System.InventoryManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .inventory-container {
            padding: 20px;
        }
        .inventory-container h2 {
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
        .alert {
            color: #d9534f;
            font-weight: bold;
        }
        .button-panel {
            margin-top: 20px;
        }
        .turnover-summary {
            margin-top: 20px;
            padding: 15px;
            background-color: #ecf0f1;
            border-radius: 5px;
        }
        .create-inventory-form {
            margin: 20px 0;
            padding: 15px;
            background-color: #ecf0f1;
            border-radius: 5px;
        }
        .create-inventory-form label {
            display: inline-block;
            width: 120px;
            font-weight: bold;
        }
        .create-inventory-form input, .create-inventory-form select {
            margin-bottom: 10px;
            padding: 5px;
            width: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="inventory-container">
        <h2>Inventory Management</h2>
        <p>Monitor stock levels, set reorder points, and manage inventory.</p>

        <!-- Create Inventory Form -->
        <div class="create-inventory-form">
            <h3>Create New Inventory Item</h3>
            <div>
                <label for="txtItemName">Item Name:</label>
                <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="ddlLocation">Location:</label>
                <asp:DropDownList ID="ddlLocation" runat="server">
                    <asp:ListItem Text="Warehouse 1" Value="Warehouse 1"></asp:ListItem>
                    <asp:ListItem Text="Warehouse 2" Value="Warehouse 2"></asp:ListItem>
                    <asp:ListItem Text="Store 1" Value="Store 1"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <label for="txtStockLevel">Stock Level:</label>
                <asp:TextBox ID="txtStockLevel" runat="server" TextMode="Number"></asp:TextBox>
            </div>
            <div>
                <label for="txtReorderPoint">Reorder Point:</label>
                <asp:TextBox ID="txtReorderPoint" runat="server" TextMode="Number"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnCreateInventory" runat="server" Text="Create Inventory" OnClick="btnCreateInventory_Click" />
            </div>
            <asp:Label ID="CreateStatusLabel" runat="server" ForeColor="Green" Visible="False"></asp:Label>
        </div>

        <!-- GridView to display inventory -->
        <asp:GridView ID="InventoryGridView" runat="server" AutoGenerateColumns="False" CssClass="grid-view" 
            DataKeyNames="ItemID">
            <Columns>
                <asp:BoundField DataField="ItemID" HeaderText="Item ID" />
                <asp:BoundField DataField="ItemName" HeaderText="Item Name" />
                <asp:BoundField DataField="Location" HeaderText="Location" />
                <asp:BoundField DataField="StockLevel" HeaderText="Stock Level" />
                <asp:BoundField DataField="ReorderPoint" HeaderText="Reorder Point" />
                <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <asp:Label ID="lblStatus" runat="server" Text='<%# GetStatus(Eval("StockLevel"), Eval("ReorderPoint")) %>' 
                            CssClass='<%# If(CInt(Eval("StockLevel")) <= CInt(Eval("ReorderPoint")), "alert", "") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

        <!-- Turnover Summary -->
        <div class="turnover-summary">
            <h3>Inventory Turnover Analysis</h3>
            <asp:Label ID="lblTurnover" runat="server" Text="Loading turnover data..."></asp:Label>
        </div>

        <!-- Button panel -->
        <div class="button-panel">
            <asp:Button ID="RefreshButton" runat="server" Text="Refresh Inventory" OnClick="RefreshButton_Click" />
            <asp:Label ID="StatusLabel" runat="server" ForeColor="Green" Visible="False"></asp:Label>
        </div>
    </div>
</asp:Content>