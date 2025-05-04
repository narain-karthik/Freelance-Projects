<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Payment.aspx.vb" Inherits="Digital_Catalog_for_Automobile.Payment" %>
<%@ Import Namespace="Digital_Catalog_for_Automobile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Custom CSS for Payment Page -->
    <style>
        .payment-page {
            max-width: 1000px;
            margin: 40px auto; /* Increased margin for spacing */
            padding: 30px;
            background-color: #fff; /* White background for contrast */
            border-radius: 10px;
            box-shadow: 0 4px 20px rgba(0, 0, 0, 0.1); /* Subtle shadow */
        }

        h1 {
            text-align: center;
            font-size: 2.2em; /* Slightly larger */
            color: #333; /* Dark gray from Master page */
            margin-bottom: 30px;
        }

        .payment-form {
            margin-top: 20px;
            padding: 20px;
            background-color: #f9f9f9; /* Light gray for form section */
            border-radius: 8px;
        }

        .payment-form label {
            display: block;
            margin-bottom: 8px;
            font-weight: 600;
            color: #333;
            font-size: 1em;
        }

        .payment-form input, .payment-form select {
            width: 100%;
            padding: 12px;
            margin-bottom: 20px;
            border: 1px solid #ddd;
            border-radius: 5px;
            box-sizing: border-box;
            font-size: 1em;
            transition: border-color 0.3s ease;
        }

        .payment-form input:focus, .payment-form select:focus {
            border-color: #663399; /* Purple focus border */
            outline: none;
        }

        .payment-methods {
            display: flex;
            flex-wrap: wrap;
            gap: 20px;
            justify-content: space-between;
        }

        .btn-submit {
            background-color: #663399; /* Changed from #28a745 (green) to #663399 (purple) */
            color: white;
            padding: 12px 30px;
            text-decoration: none;
            border: none;
            border-radius: 5px;
            font-size: 1.2em;
            font-weight: 600;
            cursor: pointer;
            display: block;
            margin: 20px auto 0; /* Centered button */
            transition: background-color 0.3s ease, transform 0.2s ease;
        }

        .btn-submit:hover {
            background-color: #552288; /* Darker purple (replaced #218838) */
            transform: translateY(-2px); /* Slight lift effect */
        }

        /* Responsive adjustments */
        @media (max-width: 768px) {
            .payment-page {
                margin: 20px auto;
                padding: 20px;
            }
            h1 {
                font-size: 1.8em;
            }
            .payment-form {
                padding: 15px;
            }
            .btn-submit {
                padding: 10px 20px;
                font-size: 1.1em;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="payment-page">
        <h1>Payment Information</h1>

        <!-- Customer Information Form -->
        <div class="payment-form">
            <label for="txtName">Full Name*</label>
            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" Placeholder="Enter your full name" Required="True" aria-label="Full Name"></asp:TextBox>

            <label for="txtEmail">Email ID*</label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Type="email" Placeholder="example@domain.com" Required="True" aria-label="Email Address"></asp:TextBox>

            <label for="txtAddress">Delivery Address*</label>
            <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" Placeholder="Enter your address" Required="True" aria-label="Delivery Address"></asp:TextBox>

            <label for="txtPincode">Pincode*</label>
            <asp:TextBox ID="txtPincode" runat="server" CssClass="form-control" MaxLength="6" Pattern="[0-9]{6}" Placeholder="6-digit pincode" Required="True" aria-label="Pincode"></asp:TextBox>

            <label for="txtPhoneNumber">Phone Number*</label>
            <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="form-control" MaxLength="10" Pattern="[0-9]{10}" Placeholder="10-digit number" Required="True" aria-label="Phone Number"></asp:TextBox>

            <!-- Order Details -->
            <label for="lblOrderDetails">Order Details</label>
            <asp:Label ID="lblOrderDetails" runat="server" CssClass="form-control" Style="display: block; background-color: #fff; border: none; padding: 10px;"></asp:Label>

            <label for="lblTotalAmount">Total Amount (₹)</label>
            <asp:Label ID="lblTotalAmount" runat="server" CssClass="form-control" Style="display: block; background-color: #fff; border: none; padding: 10px;"></asp:Label>

            <!-- Payment Method -->
            <label for="ddlPaymentMethod">Select Payment Method*</label>
            <asp:DropDownList ID="ddlPaymentMethod" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlPaymentMethod_SelectedIndexChanged" AutoPostBack="True" Required="True">
                <asp:ListItem Text="Select a method" Value="" />
                <asp:ListItem Text="UPI Barcode" Value="UPI" />
                <asp:ListItem Text="Card Payment" Value="Card" />
            </asp:DropDownList>

            <!-- UPI Payment Details -->
            <div id="upiDetails" runat="server" style="display:none;">
                <label for="txtUPI">UPI ID*</label>
                <asp:TextBox ID="txtUPI" runat="server" CssClass="form-control" Placeholder="example@upi" aria-label="UPI ID"></asp:TextBox>
                <label for="txtUPIAmount">Amount (₹)</label>
                <asp:TextBox ID="txtUPIAmount" runat="server" CssClass="form-control" ReadOnly="True" aria-label="UPI Amount"></asp:TextBox>
            </div>

            <!-- Card Payment Details -->
            <div id="cardDetails" runat="server" style="display:none;">
                <label for="txtCardNumber">Card Number*</label>
                <asp:TextBox ID="txtCardNumber" runat="server" CssClass="form-control" MaxLength="16" Pattern="[0-9]{16}" Placeholder="16-digit card number" aria-label="Card Number"></asp:TextBox>

                <label for="txtCardName">Cardholder Name*</label>
                <asp:TextBox ID="txtCardName" runat="server" CssClass="form-control" Placeholder="Name on card" aria-label="Cardholder Name"></asp:TextBox>

                <label for="txtCVV">CVV*</label>
                <asp:TextBox ID="txtCVV" runat="server" CssClass="form-control" MaxLength="3" Pattern="[0-9]{3}" Placeholder="3-digit CVV" aria-label="CVV"></asp:TextBox>

                <label for="txtExpDate">Expiration Date*</label>
                <asp:TextBox ID="txtExpDate" runat="server" CssClass="form-control" Placeholder="MM/YY" Pattern="(0[1-9]|1[0-2])\/\d{2}" aria-label="Expiration Date"></asp:TextBox>
            </div>

            <!-- Submit Button -->
            <asp:Button ID="btnSubmit" runat="server" Text="Pay Now" CssClass="btn-submit" OnClick="btnSubmit_Click" />
        </div>
    </div>
</asp:Content>
