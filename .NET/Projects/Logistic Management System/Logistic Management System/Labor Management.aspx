<%@ Page Title="Labor Management - Logistic Management System" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="LaborManagement.aspx.vb" Inherits="Logistic_Management_System.LaborManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .labor-container {
            padding: 20px;
        }
        .labor-container h2 {
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
        .compliance-alert {
            color: #d9534f;
            font-weight: bold;
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
    <div class="labor-container">
        <h2>Labor Management</h2>
        <p>Schedule tasks, monitor performance, and ensure compliance.</p>

        <!-- Create Task Form -->
        <div class="create-form">
            <h3>Create New Task Assignment</h3>
            <div>
                <label for="ddlEmployee">Employee:</label>
                <asp:DropDownList ID="ddlEmployee" runat="server">
                    <asp:ListItem Text="Alice Brown" Value="Alice Brown"></asp:ListItem>
                    <asp:ListItem Text="Bob White" Value="Bob White"></asp:ListItem>
                    <asp:ListItem Text="Clara Green" Value="Clara Green"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <label for="txtTaskDescription">Task Description:</label>
                <asp:TextBox ID="txtTaskDescription" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtScheduledDate">Scheduled Date:</label>
                <asp:TextBox ID="txtScheduledDate" runat="server" TextMode="Date"></asp:TextBox>
            </div>
            <div>
                <label for="ddlStatus">Status:</label>
                <asp:DropDownList ID="ddlStatus" runat="server">
                    <asp:ListItem Text="Pending" Value="Pending"></asp:ListItem>
                    <asp:ListItem Text="In Progress" Value="In Progress"></asp:ListItem>
                    <asp:ListItem Text="Completed" Value="Completed"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <asp:Button ID="btnCreateTask" runat="server" Text="Create Task" OnClick="btnCreateTask_Click" />
            </div>
            <asp:Label ID="CreateStatusLabel" runat="server" ForeColor="Green" Visible="False"></asp:Label>
        </div>

        <!-- Task Assignments -->
        <div class="section">
            <h3>Task Assignments</h3>
            <asp:GridView ID="TaskGridView" runat="server" AutoGenerateColumns="False" CssClass="grid-view" 
                DataKeyNames="TaskID">
                <Columns>
                    <asp:BoundField DataField="TaskID" HeaderText="Task ID" />
                    <asp:BoundField DataField="EmployeeName" HeaderText="Employee" />
                    <asp:BoundField DataField="TaskDescription" HeaderText="Task" />
                    <asp:BoundField DataField="ScheduledDate" HeaderText="Scheduled Date" DataFormatString="{0:MM/dd/yyyy}" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                </Columns>
            </asp:GridView>
        </div>

        <!-- Create Performance Entry -->
        <div class="create-form">
            <h3>Log Employee Performance</h3>
            <div>
                <label for="ddlPerformanceEmployee">Employee:</label>
                <asp:DropDownList ID="ddlPerformanceEmployee" runat="server">
                    <asp:ListItem Text="Alice Brown" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Bob White" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Clara Green" Value="3"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <label for="txtTasksCompleted">Tasks Completed:</label>
                <asp:TextBox ID="txtTasksCompleted" runat="server" TextMode="Number"></asp:TextBox>
            </div>
            <div>
                <label for="txtProductivityRate">Productivity (%):</label>
                <asp:TextBox ID="txtProductivityRate" runat="server" TextMode="Number" step="0.1"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnLogPerformance" runat="server" Text="Log Performance" OnClick="btnLogPerformance_Click" />
            </div>
            <asp:Label ID="PerformanceStatusLabel" runat="server" ForeColor="Green" Visible="False"></asp:Label>
        </div>

        <!-- Performance Monitoring -->
        <div class="section">
            <h3>Employee Performance</h3>
            <asp:GridView ID="PerformanceGridView" runat="server" AutoGenerateColumns="False" CssClass="grid-view" 
                DataKeyNames="EmployeeID">
                <Columns>
                    <asp:BoundField DataField="EmployeeID" HeaderText="Employee ID" />
                    <asp:BoundField DataField="EmployeeName" HeaderText="Name" />
                    <asp:BoundField DataField="TasksCompleted" HeaderText="Tasks Completed" />
                    <asp:BoundField DataField="ProductivityRate" HeaderText="Productivity (%)" />
                </Columns>
            </asp:GridView>
        </div>

        <!-- Create Compliance Entry -->
        <div class="create-form">
            <h3>Log Labor Compliance</h3>
            <div>
                <label for="ddlComplianceEmployee">Employee:</label>
                <asp:DropDownList ID="ddlComplianceEmployee" runat="server">
                    <asp:ListItem Text="Alice Brown" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Bob White" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Clara Green" Value="3"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <label for="txtHoursWorked">Hours Worked (Week):</label>
                <asp:TextBox ID="txtHoursWorked" runat="server" TextMode="Number" step="0.1"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnLogCompliance" runat="server" Text="Log Compliance" OnClick="btnLogCompliance_Click" />
            </div>
            <asp:Label ID="ComplianceStatusLabel" runat="server" ForeColor="Green" Visible="False"></asp:Label>
        </div>

        <!-- Compliance Check -->
        <div class="section">
            <h3>Labor Compliance</h3>
            <asp:GridView ID="ComplianceGridView" runat="server" AutoGenerateColumns="False" CssClass="grid-view" 
                DataKeyNames="EmployeeID">
                <Columns>
                    <asp:BoundField DataField="EmployeeID" HeaderText="Employee ID" />
                    <asp:BoundField DataField="EmployeeName" HeaderText="Name" />
                    <asp:BoundField DataField="HoursWorked" HeaderText="Hours Worked (Week)" />
                    <asp:TemplateField HeaderText="Compliance Status">
                        <ItemTemplate>
                            <asp:Label ID="lblCompliance" runat="server" 
                                Text='<%# GetComplianceStatus(Eval("HoursWorked")) %>' 
                                CssClass='<%# If(CDec(Eval("HoursWorked")) > 40, "compliance-alert", "") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
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