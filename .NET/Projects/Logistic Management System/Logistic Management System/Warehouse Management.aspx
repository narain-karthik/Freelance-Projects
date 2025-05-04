<%@ Page Title="Warehouse Management - Logistic Management System" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Warehouse Management.aspx.vb" Inherits="Logistic_Management_System.WarehouseManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .warehouse-container {
            padding: 20px;
        }
        .warehouse-container h2 {
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
        .section {
            margin-top: 20px;
            padding: 15px;
            background-color: #ecf0f1;
            border-radius: 5px;
        }
        .section h3 {
            margin-top: 0;
        }
        .create-warehouse-form {
            margin: 20px 0;
            padding: 15px;
            background-color: #ecf0f1;
            border-radius: 5px;
        }
        .create-warehouse-form label {
            display: inline-block;
            width: 120px;
            font-weight: bold;
        }
        .create-warehouse-form input, .create-warehouse-form select {
            margin-bottom: 10px;
            padding: 5px;
            width: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="warehouse-container">
        <h2>Warehouse Management</h2>
        <p>Organize layouts, manage workflows, and track resources.</p>

        <!-- Create Warehouse Storage Form -->
        <div class="create-warehouse-form">
            <h3>Create New Storage Assignment</h3>
            <div>
                <label for="ddlWarehouse">Warehouse:</label>
                <asp:DropDownList ID="ddlWarehouse" runat="server">
                    <asp:ListItem Text="Warehouse 1" Value="Warehouse 1"></asp:ListItem>
                    <asp:ListItem Text="Warehouse 2" Value="Warehouse 2"></asp:ListItem>
                    <asp:ListItem Text="Store 1" Value="Store 1"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <label for="txtSection">Section:</label>
                <asp:TextBox ID="txtSection" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtItemName">Item Name:</label>
                <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtQuantity">Quantity:</label>
                <asp:TextBox ID="txtQuantity" runat="server" TextMode="Number"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnCreateStorage" runat="server" Text="Create Storage Assignment" OnClick="btnCreateStorage_Click" />
            </div>
            <asp:Label ID="CreateStatusLabel" runat="server" ForeColor="Green" Visible="False"></asp:Label>
        </div>

        <!-- Storage Assignments -->
        <div class="section">
            <h3>Storage Assignments</h3>
            <asp:GridView ID="StorageGridView" runat="server" AutoGenerateColumns="False" CssClass="grid-view" 
                DataKeyNames="StorageID">
                <Columns>
                    <asp:BoundField DataField="StorageID" HeaderText="Storage ID" />
                    <asp:BoundField DataField="Warehouse" HeaderText="Warehouse" />
                    <asp:BoundField DataField="Section" HeaderText="Section" />
                    <asp:BoundField DataField="ItemName" HeaderText="Item Name" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                </Columns>
            </asp:GridView>
        </div>

        <!-- Workflow Management -->
        <div class="section">
            <h3>Workflow Management</h3>
            <asp:GridView ID="WorkflowGridView" runat="server" AutoGenerateColumns="False" CssClass="grid-view" 
                DataKeyNames="OrderID">
                <Columns>
                    <asp:BoundField DataField="OrderID" HeaderText="Order ID" />
                    <asp:BoundField DataField="CustomerName" HeaderText="Customer" />
                    <asp:BoundField DataField="PickStatus" HeaderText="Pick Status" />
                    <asp:BoundField DataField="PackStatus" HeaderText="Pack Status" />
                    <asp:BoundField DataField="ShipStatus" HeaderText="Ship Status" />
                </Columns>
            </asp:GridView>
        </div>

       <!-- Resource Utilization -->
<div class="section">
    <h3>Resource Utilization</h3>
    <asp:GridView ID="ResourceGridView" runat="server" AutoGenerateColumns="False" CssClass="grid-view" 
        DataKeyNames="ResourceID">
        <Columns>
            <asp:BoundField DataField="ResourceID" HeaderText="Resource ID" />
            <asp:BoundField DataField="ResourceType" HeaderText="Type" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Utilization" HeaderText="Utilization (%)" />
        </Columns>
    </asp:GridView>
</div>

        <!-- Button panel -->
        <div class="button-panel">
            <asp:Button ID="RefreshButton" runat="server" Text="Refresh Data" OnClick="RefreshButton_Click" />
            <asp:Label ID="StatusLabel" runat="server" ForeColor="Green" Visible="False"></asp:Label>
        </div>
    </div>
</asp:Content>