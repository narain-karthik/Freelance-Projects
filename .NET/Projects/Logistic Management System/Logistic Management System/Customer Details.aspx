<%@ Page Title="Customer Details" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Customer_Details.aspx.vb" Inherits="Logistic_Management_System.Customer_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .form-container {
            width: 50%;
            margin: auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: #f9f9f9;
        }
        .grid-container {
            margin-top: 20px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-container">
        <h2>Customer Details</h2>
        <table>
            <tr>
                <td>Customer ID:</td>
                <td><asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Customer Name:</td>
                <td><asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email:</td>
                <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Phone:</td>
                <td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSave" runat="server" Text="Save Customer" OnClick="btnSave_Click" />
                </td>
            </tr>
        </table>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Green" Visible="False"></asp:Label>
    </div>

    <div class="grid-container">
        <asp:GridView ID="CustomerGridView" runat="server" AutoGenerateColumns="False" CssClass="table">
            <Columns>
                <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" />
                <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
