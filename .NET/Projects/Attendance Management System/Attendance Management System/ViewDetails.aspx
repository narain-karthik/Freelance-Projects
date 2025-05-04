<%@ Page Title="" Language="vb" AutoEventWireup="false" 
    MasterPageFile="~/Site.Master" 
    CodeBehind="ViewDetails.aspx.vb" 
    Inherits="Attendance_Management_System.ViewDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .details-container {
            max-width: 1200px;
            margin: 2rem auto;
            padding: 2rem;
            background: white;
            border-radius: 8px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }

        .view-selector {
            margin-bottom: 2rem;
        }

        .view-label {
            display: inline-block;
            margin-right: 1rem;
            color: #666;
            font-weight: 500;
        }

        .ddl-view {
            padding: 0.5rem;
            border: 2px solid #ddd;
            border-radius: 5px;
            font-size: 1rem;
        }

        .grid-container {
            overflow-x: auto;
        }

        .details-grid {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 1rem;
        }

        .details-grid th,
        .details-grid td {
            padding: 0.75rem;
            border: 1px solid #ddd;
            text-align: left;
        }

        .details-grid th {
            background: #f5f6f5;
            color: #2c3e50;
        }

        .highlight {
            font-weight: 600;
            color: #2c3e50;
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
    <div class="details-container">
        <h2>View Details</h2>
        
        <div class="view-selector">
            <asp:Label ID="lblView" runat="server" Text="Select View:" CssClass="view-label" 
                AssociatedControlID="ddlView" />
            <asp:DropDownList ID="ddlView" runat="server" CssClass="ddl-view" AutoPostBack="true" 
                OnSelectedIndexChanged="ddlView_SelectedIndexChanged">
                <asp:ListItem Text="Select Details" Value="" />
                <asp:ListItem Text="Employee Details" Value="Employees" />
                <asp:ListItem Text="Attendance Details" Value="Attendance" />
            </asp:DropDownList>
        </div>

        <div class="grid-container">
            <asp:GridView ID="gvDetails" runat="server" CssClass="details-grid" 
                AutoGenerateColumns="false">
                <Columns>
                    <%-- Columns will be set dynamically in code-behind --%>
                </Columns>
            </asp:GridView>
        </div>

        <asp:Label ID="lblMessage" runat="server" CssClass="error-message" Visible="false" />
    </div>
</asp:Content>