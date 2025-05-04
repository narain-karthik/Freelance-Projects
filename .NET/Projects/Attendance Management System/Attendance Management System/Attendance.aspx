<%@ Page Title="" Language="vb" AutoEventWireup="false" 
    MasterPageFile="~/Site.Master" 
    CodeBehind="Attendance.aspx.vb" 
    Inherits="Attendance_Management_System.Attendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .attendance-container {
            max-width: 1000px;
            margin: 2rem auto;
            padding: 2rem;
            background: white;
            border-radius: 8px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }

        .shift-selector {
            margin-bottom: 2rem;
        }

        .shift-label {
            display: inline-block;
            margin-right: 1rem;
            color: #666;
            font-weight: 500;
        }

        .ddl-shift {
            padding: 0.5rem;
            border: 2px solid #ddd;
            border-radius: 5px;
            font-size: 1rem;
        }

        .grid-container {
            overflow-x: auto;
        }

        .attendance-grid {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 1rem;
        }

        .attendance-grid th,
        .attendance-grid td {
            padding: 0.75rem;
            border: 1px solid #ddd;
            text-align: left;
        }

        .attendance-grid th {
            background: #f5f6f5;
            color: #2c3e50;
        }

        .employee-name {
            font-weight: 600;
            color: #2c3e50;
        }

        .ddl-status {
            padding: 0.5rem;
            border: 1px solid #ddd;
            border-radius: 4px;
        }

        .btn-mark {
            background: #3498db;
            color: white;
            border: none;
            padding: 0.5rem 1rem;
            border-radius: 5px;
            cursor: pointer;
        }

        .btn-mark:hover {
            background: #2980b9;
        }

        .success-message {
            color: #27ae60;
            text-align: center;
            margin-top: 1rem;
            padding: 1rem;
            background: #e8f5e9;
            border: 1px solid #27ae60;
            border-radius: 5px;
            font-weight: 500;
        }

        .error-message {
            color: #e74c3c;
            text-align: center;
            margin-top: 1rem;
            padding: 1rem;
            background: #ffebee;
            border: 1px solid #e74c3c;
            border-radius: 5px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="attendance-container">
        <h2>Mark Attendance</h2>
        
        <div class="shift-selector">
            <asp:Label ID="lblShift" runat="server" Text="Select Shift:" CssClass="shift-label" 
                AssociatedControlID="ddlShift" />
            <asp:DropDownList ID="ddlShift" runat="server" CssClass="ddl-shift" AutoPostBack="true" 
                OnSelectedIndexChanged="ddlShift_SelectedIndexChanged">
                <asp:ListItem Text="Select Shift" Value="" />
                <asp:ListItem Text="Day" Value="Day" />
                <asp:ListItem Text="Night" Value="Night" />
            </asp:DropDownList>
        </div>

        <div class="grid-container">
            <asp:GridView ID="gvEmployees" runat="server" CssClass="attendance-grid" 
                AutoGenerateColumns="false" DataKeyNames="EmployeeID">
                <Columns>
                    <asp:BoundField DataField="EmployeeID" HeaderText="Employee ID" />
                    <asp:TemplateField HeaderText="Employee Name">
                        <ItemTemplate>
                            <span class="employee-name"><%# Eval("Name") %></span>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Shift" HeaderText="Shift" />
                    <asp:TemplateField HeaderText="Attendance Status">
                        <ItemTemplate>
                            <asp:DropDownList ID="ddlStatus" runat="server" CssClass="ddl-status">
                                <asp:ListItem Text="Present" Value="Present" />
                                <asp:ListItem Text="Absent" Value="Absent" />
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:Button ID="btnMarkAttendance" runat="server" Text="Mark" 
                                CssClass="btn-mark" 
                                CommandArgument='<%# Eval("EmployeeID") & "," & Eval("Name") %>'
                                OnClick="btnMarkAttendance_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        <asp:Label ID="lblMessage" runat="server" Visible="false" />
    </div>
</asp:Content>