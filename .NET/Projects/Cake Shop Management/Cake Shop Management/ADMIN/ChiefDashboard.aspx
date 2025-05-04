<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ChiefDashboard.aspx.vb" Inherits="Cake_Shop_Management.ChiefDashboard_aspx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Chief Dashboard - Cake Shop</title>
    <!-- Google Font -->
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;500;700&display=swap" rel="stylesheet">
    <!-- Bootstrap 5 CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            font-family: 'Roboto', sans-serif;
            background-color: #f4f7fc;
            margin: 0;
        }

        .navbar {
            background-color: #343a40;
        }

        .navbar-brand, .nav-link, .logout-btn {
            color: #FF3300 !important;
            font-weight: 700;
        }

        .dashboard-card {
            background: #fff;
            border-radius: 12px;
            padding: 30px;
            margin-top: 40px;
            box-shadow: 0 4px 20px rgba(0, 0, 0, 0.08);
        }

        h2 {
            font-weight: 700;
            color: #4caf50;
            margin-bottom: 25px;
        }

        .btn-action {
            width: 120px;
            border-radius: 8px;
            font-weight: 500;
        }

        .btn-accept {
            background-color: #28a745;
            color: #fff;
        }

        .btn-deny {
            background-color: #dc3545;
            color: #fff;
        }

        .btn-accept:hover {
            background-color: #218838;
        }

        .btn-deny:hover {
            background-color: #c82333;
        }

        .table th, .table td {
            vertical-align: middle;
            text-align: center;
        }

        .alert-message {
            margin-top: 20px;
            padding: 15px;
            border-radius: 8px;
            display: none;
            text-align: center;
        }

        .modal-confirm .modal-header {
            background-color: #4caf50;
            color: #fff;
        }

        @media (max-width: 768px) {
            .dashboard-card {
                padding: 20px;
            }
        }
        .style1
        {
            font-size: var(--bs-navbar-brand-font-size);
            text-decoration: none;
            white-space: nowrap;
            font-weight: 500;
            margin-right: var(--bs-navbar-brand-margin-end);
            padding-top: var(--bs-navbar-brand-padding-y);
            padding-bottom: var(--bs-navbar-brand-padding-y);
        }
        .style2
        {
            color: #000000;
        }
        .style3
        {
            font-size: var(--bs-navbar-brand-font-size);
            color: #000000;
            text-decoration: none;
            white-space: nowrap;
            font-weight: 700;
            margin-right: var(--bs-navbar-brand-margin-end);
            padding-top: var(--bs-navbar-brand-padding-y);
            padding-bottom: var(--bs-navbar-brand-padding-y);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Navbar -->
        <nav class="navbar navbar-expand-lg navbar-dark">
            <div class="container-fluid">
                <a class="style1" href="#"><span class="style2"><strong>Cake Shop - Chief Dashboar</strong></span></a><a 
                    class="style3" href="#">d</a>
                <asp:Button ID="btnLogout" runat="server" CssClass="btn btn-outline-light logout-btn" Text="Logout" PostBackUrl="~/login.aspx" />
            </div>
        </nav>

        <!-- Dashboard -->
        <div class="container">
            <div class="dashboard-card">
                <h2>Order Management</h2>

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"
                    CssClass="table table-bordered table-striped">
                    <Columns>
                        <asp:BoundField DataField="FullName" HeaderText="Full Name" SortExpression="FullName" />
                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                        <asp:BoundField DataField="OrderDetails" HeaderText="Order Details" SortExpression="OrderDetails" />
                        <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" SortExpression="PhoneNumber" />
                        <asp:BoundField DataField="TotalAmount" HeaderText="Total Amount" SortExpression="TotalAmount" />
                        <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                        <asp:BoundField DataField="Pincode" HeaderText="Pincode" SortExpression="Pincode" />
                    </Columns>
                </asp:GridView>

                <div class="text-center mt-4 d-flex justify-content-center gap-3">
                    <button type="button" class="btn btn-action btn-accept" data-bs-toggle="modal" data-bs-target="#confirmAccept">Accept</button>
                    <button type="button" class="btn btn-action btn-deny" data-bs-toggle="modal" data-bs-target="#confirmDeny">Deny</button>
                </div>

                <div id="messageBox" class="alert-message"></div>

                <!-- Accept Modal -->
                <div class="modal fade" id="confirmAccept" tabindex="-1" aria-labelledby="acceptLabel" aria-hidden="true">
                    <div class="modal-dialog modal-dialog-centered">
                        <div class="modal-content modal-confirm">
                            <div class="modal-header">
                                <h5 class="modal-title" id="acceptLabel">Confirm Acceptance</h5>
                                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                            </div>
                            <div class="modal-body text-center">
                                Are you sure you want to accept this order?
                            </div>
                            <div class="modal-footer justify-content-center">
                                <button type="button" class="btn btn-success" onclick="showMessage('accept')" data-bs-dismiss="modal">Yes, Accept</button>
                                <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancel</button>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Deny Modal -->
                <div class="modal fade" id="confirmDeny" tabindex="-1" aria-labelledby="denyLabel" aria-hidden="true">
                    <div class="modal-dialog modal-dialog-centered">
                        <div class="modal-content modal-confirm">
                            <div class="modal-header bg-danger">
                                <h5 class="modal-title text-white" id="denyLabel">Confirm Rejection</h5>
                                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                            </div>
                            <div class="modal-body text-center">
                                Are you sure you want to deny this order?
                            </div>
                            <div class="modal-footer justify-content-center">
                                <button type="button" class="btn btn-danger" onclick="showMessage('deny')" data-bs-dismiss="modal">Yes, Deny</button>
                                <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancel</button>
                            </div>
                        </div>
                    </div>
                </div>

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CakeConnectionString %>" 
                    SelectCommand="SELECT [FullName], [Email], [OrderDetails], [PhoneNumber], [TotalAmount], [Address], [Pincode] FROM [Payments]">
                </asp:SqlDataSource>
            </div>
        </div>
    </form>

    <!-- Bootstrap Bundle JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    <script>
        function showMessage(status) {
            var messageBox = document.getElementById("messageBox");
            if (status === 'accept') {
                messageBox.className = "alert-message alert-success";
                messageBox.innerHTML = "✅ Order has been accepted by the chief.";
            } else {
                messageBox.className = "alert-message alert-danger";
                messageBox.innerHTML = "❌ Order has been denied by the chief.";
            }
            messageBox.style.display = "block";
            setTimeout(() => { messageBox.style.display = 'none'; }, 4000);
        }
    </script>
</body>
</html>
