<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Cart.aspx.vb" Inherits="Digital_Catalog_for_Automobile.Cart" %>
<%@ Import Namespace="Digital_Catalog_for_Automobile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Custom CSS for Cart Page -->
    <style>
        /* Cart Page Layout */
        .cart-page {
            max-width: 1200px;
            margin: 40px auto; /* Increased margin for spacing */
            padding: 20px;
            background-color: #fff; /* White background for contrast */
            border-radius: 10px;
            box-shadow: 0 4px 20px rgba(0, 0, 0, 0.1); /* Subtle shadow */
        }

        h1 {
            text-align: center;
            font-size: 2.2em; /* Slightly larger for emphasis */
            color: #333; /* Dark gray from Master page */
            margin-bottom: 30px;
        }

        .cart-item {
            border: 1px solid #ddd;
            border-radius: 8px;
            padding: 15px;
            margin-bottom: 20px;
            display: flex;
            justify-content: space-between;
            align-items: center;
            background-color: #f9f9f9; /* Light gray for contrast */
            transition: box-shadow 0.3s ease;
        }

        .cart-item:hover {
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1); /* Hover effect */
        }

        .cart-item-details {
            flex-grow: 1;
            padding-right: 15px;
        }

        .cart-item-details strong {
            color: #333;
        }

        .cart-item .remove-item {
            color: #d9534f; /* Red for remove link */
            cursor: pointer;
            font-size: 14px;
            text-decoration: none;
            font-weight: 600;
        }

        .cart-item .remove-item:hover {
            text-decoration: underline;
        }

        .cart-total {
            font-size: 1.3em; /* Slightly larger */
            margin-top: 30px;
            text-align: right;
            color: #333;
        }

        .cart-footer {
            margin-top: 30px;
            text-align: center;
        }

        .btn-proceed {
            background-color: #663399; /* Changed from #007bff (blue) to #663399 (purple) */
            color: white;
            padding: 12px 25px;
            text-decoration: none;
            border-radius: 5px;
            font-size: 1.1em;
            font-weight: 600;
            display: inline-block;
            transition: background-color 0.3s ease, transform 0.2s ease;
        }

        .btn-proceed:hover {
            background-color: #552288; /* Darker purple for hover */
            transform: translateY(-2px); /* Slight lift effect */
        }

        /* Responsive adjustments */
        @media (max-width: 768px) {
            .cart-page {
                margin: 20px auto;
                padding: 15px;
            }
            h1 {
                font-size: 1.8em;
            }
            .cart-item {
                flex-direction: column;
                align-items: flex-start;
            }
            .cart-item-details {
                padding-right: 0;
                margin-bottom: 10px;
            }
            .cart-total {
                font-size: 1.1em;
                text-align: center;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cart-page">
        <h1>Your Shopping Cart</h1>

        <%
            ' Retrieve cart items from Session
            Dim cartItems As List(Of CartItem) = Session("Cart")
            
            ' If cart is empty, initialize it
            If cartItems Is Nothing Then
                cartItems = New List(Of CartItem)
                Session("Cart") = cartItems
            End If

            If cartItems.Count > 0 Then
                For Each item As CartItem In cartItems
        %>
        <div class="cart-item">
            <div class="cart-item-details">
                <strong>Vehicle Model:</strong> <%= item.ProductName %><br />
                <strong>Price:</strong> ₹<%= item.ProductPrice.ToString("F2") %><br />
                <strong>Quantity:</strong> <%= item.Quantity %><br />
                <strong>Subtotal:</strong> ₹<%= (item.ProductPrice * item.Quantity).ToString("F2") %><br />
            </div>
            <a href="Cart.aspx?remove=<%= item.ProductId %>" class="remove-item">Remove</a>
        </div>
        <%
            Next
            Else
        %>
        <p style="text-align: center; color: #666;">Your cart is empty. Start exploring our vehicle catalog!</p>
        <%
            End If
        %>

        <div class="cart-total">
            <strong>Total: ₹
                <% 
                    Dim total As Decimal = cartItems.Sum(Function(item) item.ProductPrice * item.Quantity)
                    Response.Write(total.ToString("F2"))
                %>
            </strong>
        </div>

        <div class="cart-footer">
            <a href="Payment.aspx" class="btn-proceed">Proceed to Payment</a>
        </div>
    </div>
</asp:Content>
