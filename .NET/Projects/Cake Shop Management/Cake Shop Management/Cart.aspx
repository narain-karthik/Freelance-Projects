<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Cart.aspx.vb" Inherits="Cake_Shop_Management.Cart" %>

<%@ Import Namespace="Cake_Shop_Management" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Shopping Cart</title>

    <!-- Custom CSS for Cart Page -->
    <style>
        /* Cart Page Layout */
        .cart-page {
            max-width: 1200px;
            margin: 0 auto;
            padding: 20px;
        }

        h1 {
            text-align: center;
            font-size: 2em;
            margin-bottom: 20px;
        }

        .cart-item {
            border: 1px solid #ddd;
            border-radius: 8px;
            padding: 15px;
            margin-bottom: 20px;
            display: flex;
            justify-content: space-between;
        }

        .cart-item-details {
            flex-grow: 1;
        }

        .cart-item .remove-item {
            color: red;
            cursor: pointer;
            font-size: 14px;
        }

        .cart-total {
            font-size: 1.2em;
            margin-top: 30px;
            text-align: right;
        }

        .cart-footer {
            margin-top: 20px;
            text-align: center;
        }

        .btn-proceed {
            background-color: #007bff;
            color: white;
            padding: 10px 20px;
            text-decoration: none;
            border-radius: 5px;
            font-size: 1em;
        }

        .btn-proceed:hover {
            background-color: #0056b3;
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
                <strong>Product Name:</strong> <%= item.ProductName %><br />
                <strong>Price:</strong> ₹<%= item.ProductPrice %><br />
                <strong>Quantity:</strong> <%= item.Quantity %><br />
                <strong>Subtotal:</strong> ₹<%= item.ProductPrice * item.Quantity %><br />
            </div>
            <a href="Cart.aspx?remove=<%= item.ProductId %>" class="remove-item">Remove</a>
        </div>
        <%
            Next
            Else
        %>
        <p>Your cart is empty.</p>
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
