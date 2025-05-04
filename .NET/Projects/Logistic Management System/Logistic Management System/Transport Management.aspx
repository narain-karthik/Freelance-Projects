<%@ Page Title="Transport Management - Logistic Management System" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="TransportManagement.aspx.vb" Inherits="Logistic_Management_System.TransportManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .transport-container {
            padding: 20px;
        }
        .transport-container h2 {
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
        .create-form {
            margin: 20px 0;
            padding: 15px;
            background-color: #ecf0f1;
            border-radius: 5px;
        }
        .create-form label {
            display: inline-block;
            width: 120px;
            font-weight: bold;
        }
        .create-form input, .create-form select {
            margin-bottom: 10px;
            padding: 5px;
            width: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="transport-container">
        <h2>Transport Management</h2>
        <p>Plan routes, track shipments, and manage resources.</p>

        <!-- Create Delivery Route -->
        <div class="create-form">
            <h3>Create New Delivery Route</h3>
            <div>
                <label for="txtOrigin">Origin:</label>
                <asp:TextBox ID="txtOrigin" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtDestination">Destination:</label>
                <asp:TextBox ID="txtDestination" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtDistance">Distance (km):</label>
                <asp:TextBox ID="txtDistance" runat="server" TextMode="Number" step="0.1"></asp:TextBox>
            </div>
            <div>
                <label for="txtEstimatedTime">Est. Time (hrs):</label>
                <asp:TextBox ID="txtEstimatedTime" runat="server" TextMode="Number" step="0.1"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnCreateRoute" runat="server" Text="Create Route" OnClick="btnCreateRoute_Click" />
            </div>
            <asp:Label ID="RouteStatusLabel" runat="server" ForeColor="Green" Visible="False"></asp:Label>
        </div>

        <!-- Delivery Routes -->
        <div class="section">
            <h3>Delivery Routes</h3>
            <asp:GridView ID="RouteGridView" runat="server" AutoGenerateColumns="False" CssClass="grid-view" 
                DataKeyNames="RouteID">
                <Columns>
                    <asp:BoundField DataField="RouteID" HeaderText="Route ID" />
                    <asp:BoundField DataField="Origin" HeaderText="Origin" />
                    <asp:BoundField DataField="Destination" HeaderText="Destination" />
                    <asp:BoundField DataField="Distance" HeaderText="Distance (km)" />
                    <asp:BoundField DataField="EstimatedTime" HeaderText="Est. Time (hrs)" />
                </Columns>
            </asp:GridView>
        </div>

        <!-- Create Shipment -->
        <div class="create-form">
            <h3>Create New Shipment</h3>
            <div>
                <label for="ddlVehicle">Vehicle:</label>
                <asp:DropDownList ID="ddlVehicle" runat="server">
                    <asp:ListItem Text="V001" Value="V001"></asp:ListItem>
                    <asp:ListItem Text="V002" Value="V002"></asp:ListItem>
                    <asp:ListItem Text="V003" Value="V003"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <label for="txtCurrentLocation">Current Location:</label>
                <asp:TextBox ID="txtCurrentLocation" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="ddlShipmentStatus">Status:</label>
                <asp:DropDownList ID="ddlShipmentStatus" runat="server">
                    <asp:ListItem Text="Loading" Value="Loading"></asp:ListItem>
                    <asp:ListItem Text="In Transit" Value="In Transit"></asp:ListItem>
                    <asp:ListItem Text="Delivered" Value="Delivered"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <asp:Button ID="btnCreateShipment" runat="server" Text="Create Shipment" OnClick="btnCreateShipment_Click" />
            </div>
            <asp:Label ID="ShipmentStatusLabel" runat="server" ForeColor="Green" Visible="False"></asp:Label>
        </div>

        <!-- Shipment Tracking -->
        <div class="section">
            <h3>Shipment Tracking</h3>
            <asp:GridView ID="ShipmentGridView" runat="server" AutoGenerateColumns="False" CssClass="grid-view" 
                DataKeyNames="ShipmentID">
                <Columns>
                    <asp:BoundField DataField="ShipmentID" HeaderText="Shipment ID" />
                    <asp:BoundField DataField="VehicleID" HeaderText="Vehicle ID" />
                    <asp:BoundField DataField="CurrentLocation" HeaderText="Current Location" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                    <asp:BoundField DataField="LastUpdated" HeaderText="Last Updated" DataFormatString="{0:MM/dd/yyyy HH:mm}" />
                </Columns>
            </asp:GridView>
        </div>

        <!-- Create Resource -->
        <div class="create-form">
            <h3>Create New Resource</h3>
            <div>
                <label for="txtVehicleID">Vehicle ID:</label>
                <asp:TextBox ID="txtVehicleID" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtDriverName">Driver Name:</label>
                <asp:TextBox ID="txtDriverName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtSchedule">Schedule:</label>
                <asp:TextBox ID="txtSchedule" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtFuelCost">Fuel Cost ($):</label>
                <asp:TextBox ID="txtFuelCost" runat="server" TextMode="Number" step="0.01"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnCreateResource" runat="server" Text="Create Resource" OnClick="btnCreateResource_Click" />
            </div>
            <asp:Label ID="ResourceStatusLabel" runat="server" ForeColor="Green" Visible="False"></asp:Label>
        </div>

        <!-- Resource Management -->
<div class="section">
    <h3>Resource Management</h3>
    <asp:GridView ID="ResourceGridView" runat="server" AutoGenerateColumns="False" CssClass="grid-view" 
        DataKeyNames="VehicleID">
        <Columns>
            <asp:BoundField DataField="VehicleID" HeaderText="Vehicle ID" />
            <asp:BoundField DataField="DriverName" HeaderText="Driver" />
            <asp:BoundField DataField="Schedule" HeaderText="Schedule" />
            <asp:BoundField DataField="FuelCost" HeaderText="Fuel Cost ($)" />
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