<%@ Page Title="" Language="vb" AutoEventWireup="false" 
    MasterPageFile="~/Site.Master" 
    CodeBehind="AddEmployee.aspx.vb" 
    Inherits="Attendance_Management_System.AddEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .form-container {
            max-width: 800px;
            margin: 2rem auto;
            padding: 2rem;
            background: white;
            border-radius: 8px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }

        .form-header {
            color: #2c3e50;
            margin-bottom: 1.5rem;
            font-size: 1.8rem;
        }

        .form-group {
            margin-bottom: 1.5rem;
        }

        .form-group label {
            display: block;
            margin-bottom: 0.5rem;
            color: #666;
            font-weight: 500;
        }

        .form-group input,
        .form-group select {
            width: 100%;
            padding: 0.75rem;
            border: 2px solid #ddd;
            border-radius: 5px;
            font-size: 1rem;
            transition: border-color 0.3s ease;
        }

        .form-group input:focus,
        .form-group select:focus {
            outline: none;
            border-color: #3498db;
            box-shadow: 0 0 5px rgba(52, 152, 219, 0.2);
        }

        .btn-submit {
            background: #3498db;
            color: white;
            padding: 0.75rem 2rem;
            border: none;
            border-radius: 5px;
            font-size: 1rem;
            cursor: pointer;
            transition: background 0.3s ease;
        }

        .btn-submit:hover {
            background: #2980b9;
        }

        .success-message {
            color: #27ae60;
            text-align: center;
            margin-top: 1rem;
        }

        .error-message {
            color: #e74c3c;
            text-align: center;
            margin-top: 1rem;
        }

        @media (max-width: 768px) {
            .form-container {
                margin: 1rem;
                padding: 1.5rem;
            }
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
            font-weight: 500;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-container">
        <h2 class="form-header">Add New Employee</h2>
        
        <div class="form-group">
            <asp:Label ID="lblName" runat="server" Text="Name" AssociatedControlID="txtName" />
            <asp:TextBox ID="txtName" runat="server" placeholder="Enter full name" />
        </div>

        <div class="form-group">
            <asp:Label ID="lblEmployeeID" runat="server" Text="Employee ID" AssociatedControlID="txtEmployeeID" />
            <asp:TextBox ID="txtEmployeeID" runat="server" placeholder="Enter employee ID" />
        </div>

        <div class="form-group">
            <asp:Label ID="lblDOB" runat="server" Text="Date of Birth" AssociatedControlID="txtDOB" />
            <asp:TextBox ID="txtDOB" runat="server" TextMode="Date" />
        </div>

        <div class="form-group">
            <asp:Label ID="lblAddress" runat="server" Text="Address" AssociatedControlID="txtAddress" />
            <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Rows="3" 
                placeholder="Enter full address" Height="150px" Width="450px" />
        </div>

        <div class="form-group">
            <asp:Label ID="lblPhone" runat="server" Text="Phone Number" AssociatedControlID="txtPhone" />
            <asp:TextBox ID="txtPhone" runat="server" TextMode="Phone" placeholder="Enter phone number" />
        </div>

        <div class="form-group">
            <asp:Label ID="lblPAN" runat="server" Text="PAN Card Number" AssociatedControlID="txtPAN" />
            <asp:TextBox ID="txtPAN" runat="server" placeholder="Enter PAN card number" />
        </div>

        <div class="form-group">
            <asp:Label ID="lblJoiningDate" runat="server" Text="Date of Joining" AssociatedControlID="txtJoiningDate" />
            <asp:TextBox ID="txtJoiningDate" runat="server" TextMode="Date" />
        </div>

        <div class="form-group">
            <asp:Label ID="lblShift" runat="server" Text="Shift" AssociatedControlID="ddlShift" />
            <asp:DropDownList ID="ddlShift" runat="server">
                <asp:ListItem Text="Select Shift" Value="" />
                <asp:ListItem Text="Day" Value="Day" />
                <asp:ListItem Text="Night" Value="Night" />
            </asp:DropDownList>
        </div>

        <div class="form-group">
            <asp:Button ID="btnSubmit" runat="server" Text="Add Employee" CssClass="btn-submit" OnClick="btnSubmit_Click" />
        </div>

        <asp:Label ID="lblMessage" runat="server" Visible="false" />
    </div>
</asp:Content>