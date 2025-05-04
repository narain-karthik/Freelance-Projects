<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Menu.aspx.vb" Inherits="Cake_Shop_Management.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Products</title>
    <style>
        .product-container {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            grid-gap: 20px;
            padding: 20px;
        }

        .product {
            border: 1px solid #ccc;
            padding: 20px;
            text-align: center;
            box-shadow: 2px 2px 5px rgba(0,0,0,0.1);
            border-radius: 8px;
            transition: transform 0.2s;
            background-color: #f9f9f9;
        }

        .product:hover {
            transform: scale(1.05);
        }

        .product img {
            max-width: 100%;
            height: auto;
            margin-bottom: 10px;
            border-radius: 4px;
        }

        .product h3 {
            margin-bottom: 5px;
            color: #333;
        }

        .product p {
            margin-bottom: 10px;
        }

        .quantity-selector {
            display: flex;
            align-items: center;
            margin-bottom: 10px;
            justify-content: center;
        }

        .quantity-input {
            width: 50px;
            padding: 5px;
            margin-left: 5px;
            border: 1px solid #ccc;
            border-radius: 4px;
            text-align: center;
        }

        .buy-button {
            display: inline-block;
            padding: 10px 20px;
            background-color: #007bff;
            color: white;
            text-decoration: none;
            border-radius: 5px;
            transition: background-color 0.3s;
            margin-top: 10px; /* Space from quantity */
        }

        .buy-button:hover {
            background-color: #0056b3;
        }
        .style1
        {
            color: #FFD700;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center> <h1 class="style1">Select your Cake</h1></center>   
    <div class="product-container">

        <div class="product">
            <img src="p1.jpg" alt="Kesar Badam Tres Leches">
            <h3>Kesar Badam Tres Leches</h3>
            <p>Kesar Badam Tres Leches ₹1,200 / 500gm</p>
            <p>Price: ₹1200</p>
            <div class="quantity-selector">
                <label for="quantity1">Quantity:</label>
                <input type="number" id="quantity1" name="quantity1" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(1, 'Kesar Badam Tres Leches (500gm)', 1200, 'quantity1')" class="buy-button">Buy Now</a>
        </div>

        <div class="product">
            <img src="p2.jpg" alt="Fresh Cream Pineapple Cake">
            <h3>Fresh Cream Pineapple Cake</h3>
            <p>Fresh Cream Pineapple Cake ₹650 / 500gm </p>
            <p>Price: ₹650 </p>
            <div class="quantity-selector">
                <label for="quantity2">Quantity:</label>
                <input type="number" id="quantity2" name="quantity2" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(2, 'Fresh Cream Pineapple Cake (500gm)', 650, 'quantity2')" class="buy-button">Buy Now</a>
        </div>

        <div class="product">
            <img src="p3.jpg" alt="New York Style Baked Cheesecake">
            <h3>New York Style Baked Cheesecake</h3>
            <p>New York Style Baked Cheesecake ₹1400 / 1kg </p>
            <p>Price: ₹1400</p>
            <div class="quantity-selector">
                <label for="quantity3">Quantity:</label>
                <input type="number" id="quantity3" name="quantity3" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(3, 'New York Style Baked Cheesecake (1kg)', 1400, 'quantity3')" class="buy-button">Buy Now</a>
        </div>

        <div class="product">
            <img src="p7.jpg" alt="Almond Biscotti">
            <h3>Almond Biscotti</h3>
            <p>Almond Biscotti ₹220 / 3pcs</p>
            <p>Price:₹220</p>
            <div class="quantity-selector">
                <label for="quantity4">Quantity:</label>
                <input type="number" id="quantity4" name="quantity4" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(4, 'Almond Biscotti (3pcs)', 220, 'quantity4')" class="buy-button">Buy Now</a>
        </div>

        <div class="product">
            <img src="p4.jpg" alt="Blueberry Cheesecake">
            <h3>Blueberry Cheesecake</h3>
            <p>Blueberry Cheesecake ₹775 / 500gm</p>
            <p>Price:₹775 </p>
            <div class="quantity-selector">
                <label for="quantity5">Quantity:</label>
                <input type="number" id="quantity5" name="quantity5" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(5, 'Blueberry Cheesecake (500gm)', 775, 'quantity5')" class="buy-button">Buy Now</a>
        </div>

        <div class="product">
            <img src="p5.jpg" alt="Eggless Dutch Truffle Cake">
            <h3>Eggless Dutch Truffle Cake</h3>
            <p>Eggless Dutch Truffle Cake ₹680 / 500gm</p>
            <p>Price: ₹680</p>
            <div class="quantity-selector">
                <label for="quantity6">Quantity:</label>
                <input type="number" id="quantity6" name="quantity6" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(6, 'Eggless Dutch Truffle Cake (500gm)', 680, 'quantity6')" class="buy-button">Buy Now</a>
        </div>

        <div class="product">
            <img src="p6.jpg" alt="Walnut Brownie">
            <h3>Walnut Brownie</h3>
            <p>TWalnut Brownie ₹118 / 2pcs</p>
            <p>Price: ₹118</p>
            <div class="quantity-selector">
                <label for="quantity7">Quantity:</label>
                <input type="number" id="quantity7" name="quantity7" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(7, 'Walnut Brownie (2pcs)', 118, 'quantity7')" class="buy-button">Buy Now</a>
        </div>

    </div>

    <script>
        function addToCart(id, name, price, quantityId) {
            var quantity = document.getElementById(quantityId).value;
            var url = "Cart.aspx?id=" + id + "&name=" + encodeURIComponent(name) + "&price=" + price + "&quantity=" + quantity;
            window.location.href = url;
        }
    </script>
</asp:Content>
