<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="PaymentConfirmation.aspx.vb" Inherits="Digital_Catalog_for_Automobile.PaymentConfirmation" %>
<%@ Import Namespace="Digital_Catalog_for_Automobile" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Custom CSS for Confirmation Page -->
    <style>
        .confirmation-page {
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

        .order-details {
            margin-top: 20px;
            padding: 20px;
            background-color: #f9f9f9; /* Light gray for details section */
            border-radius: 8px;
            font-size: 1.1em; /* Slightly smaller than original */
        }

        .order-details label {
            font-weight: 600;
            display: block;
            margin-top: 15px;
            color: #333;
        }

        .order-details span {
            color: #666; /* Medium gray for values */
            display: block;
            margin-bottom: 10px;
        }

        .btn-home {
            background-color: #663399; /* Changed from #007bff (blue) to #663399 (purple) */
            color: white;
            padding: 12px 30px;
            text-decoration: none;
            border: none;
            border-radius: 5px;
            font-size: 1.2em;
            font-weight: 600;
            cursor: pointer;
            display: block;
            margin: 30px auto 0; /* Centered with top spacing */
            transition: background-color 0.3s ease, transform 0.2s ease;
        }

        .btn-home:hover {
            background-color: #552288; /* Darker purple (replaced #0056b3) */
            transform: translateY(-2px); /* Slight lift effect */
        }

        /* Responsive adjustments */
        @media (max-width: 768px) {
            .confirmation-page {
                margin: 20px auto;
                padding: 20px;
            }
            h1 {
                font-size: 1.8em;
            }
            .order-details {
                font-size: 1em;
            }
            .btn-home {
                padding: 10px 20px;
                font-size: 1.1em;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="confirmation-page">
        <h1>Payment Confirmation</h1>

        <!-- Display Order Details -->
        <div class="order-details">
            <label for="lblFullName">Full Name</label>
            <asp:Label ID="lblFullName" runat="server"></asp:Label>

            <label for="lblEmail">Email ID</label>
            <asp:Label ID="lblEmail" runat="server"></asp:Label>

            <label for="lblAddress">Address</label>
            <asp:Label ID="lblAddress" runat="server"></asp:Label>

            <label for="lblOrderDetails">Ordered Product Details</label>
            <asp:Label ID="lblOrderDetails" runat="server"></asp:Label>

            <label for="lblTotalAmount">Total Amount</label>
            <asp:Label ID="lblTotalAmount" runat="server"></asp:Label>

            <label for="lblPaymentMethod">Payment Method</label>
            <asp:Label ID="lblPaymentMethod" runat="server"></asp:Label>

            <label for="lblPaymentStatus">Payment Status</label>
            <asp:Label ID="lblPaymentStatus" runat="server"></asp:Label>
        </div>

        <!-- Button to return to homepage -->
      <asp:Button ID="btnHome" runat="server" Text="Back to Home" CssClass="btn-home" OnClick="btnHome_Click" />
    </div>
</asp:Content>
