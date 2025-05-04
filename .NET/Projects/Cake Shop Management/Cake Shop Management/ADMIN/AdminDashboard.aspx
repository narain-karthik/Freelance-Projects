<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AdminDashboard.aspx.vb" Inherits="Cake_Shop_Management.AdminDashboard" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Admin Dashboard - Cake Shop</title>
    <!-- Bootstrap CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;500;700&display=swap" rel="stylesheet">
    <style type="text/css">
        body {
            background-color: #f0f4f8;
            font-family: 'Roboto', sans-serif;
        }
        .dashboard-container {
            padding: 30px;
        }
        .dashboard-card {
            background-color: #ffffff;
            border-radius: 15px;
            box-shadow: 0 4px 16px rgba(0, 0, 0, 0.1);
            padding: 25px;
        }
        h2 {
            font-weight: 700;
            color: #4caf50;
            margin-bottom: 20px;
        }
        .btn-logout {
            background-color: #f44336;
            color: white;
            border-radius: 50px;
            font-weight: 500;
            padding: 8px 20px;
            border: none;
        }
        .btn-logout:hover {
            background-color: #d32f2f;
            cursor: pointer;
        }
        .table {
            margin-top: 20px;
        }
        .table thead {
            background-color: #2e3b4e;
            color: white;
        }
        .table th, .table td {
            text-align: center;
        }
        .table-hover tbody tr:hover {
            background-color: #f1f1f1;
        }
        .table-bordered th, .table-bordered td {
            border: 1px solid #ddd;
        }
        .table-striped tbody tr:nth-of-type(odd) {
            background-color: #f7f7f7;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container dashboard-container">
            <div class="dashboard-card">
                <div class="d-flex justify-content-between align-items-center">
                    <h2>Admin Dashboard - Cake Shop</h2>
                    <asp:Button ID="Button1" runat="server" PostBackUrl="~/login.aspx" Text="Logout" CssClass="btn-logout" />
                </div>
                
                <div class="table-responsive">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
                        DataKeyNames="PaymentID" DataSourceID="SqlDataSource1" CssClass="table table-bordered table-striped table-hover">
                        <Columns>
                            <asp:BoundField DataField="FullName" HeaderText="Full Name" SortExpression="FullName" />
                            <asp:BoundField DataField="PaymentID" HeaderText="Payment ID" SortExpression="PaymentID" ReadOnly="True" />
                            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                            <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" SortExpression="PhoneNumber" />
                            <asp:BoundField DataField="OrderDetails" HeaderText="Order Details" SortExpression="OrderDetails" />
                            <asp:BoundField DataField="TotalAmount" HeaderText="Total Amount" SortExpression="TotalAmount" />
                            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                            <asp:BoundField DataField="Pincode" HeaderText="Pincode" SortExpression="Pincode" />
                        </Columns>
                    </asp:GridView>
                </div>
                
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                    ConnectionString="<%$ ConnectionStrings:CakeConnectionString %>"
                    SelectCommand="SELECT [FullName], [PaymentID], [Email], [PhoneNumber], [OrderDetails], [TotalAmount], [Address], [Pincode] FROM [Payments]">
                </asp:SqlDataSource>
            </div>
        </div>
    </form>
</body>
</html>
