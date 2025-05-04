<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master_Page.Master" CodeBehind="Products.aspx.vb" Inherits="Dairy_Product_Management.Products" %>
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Our Products</h1>
    <div class="product-container">

        <div class="product">
            <img src="new/milk.png" alt="Farm Fresh Milk">
            <h3>Farm Fresh Milk 500ml</h3>
            <p>Farm Fresh Homogenised Cow Milk ₹37 / 500ml</p>
            <p>Price: ₹37</p>
            <div class="quantity-selector">
                <label for="quantity1">Quantity:</label>
                <input type="number" id="quantity1" name="quantity1" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(1, 'Farm Fresh Milk', 37, 'quantity1')" class="buy-button">Buy Now</a>
        </div>

        <div class="product">
            <img src="new/milk.png" alt="Buffalo Milk">
            <h3>Buffalo Milk 500ml</h3>
            <p>Buffalo Toned Milk ₹35 / 500ml </p>
            <p>Price: ₹35 </p>
            <div class="quantity-selector">
                <label for="quantity2">Quantity:</label>
                <input type="number" id="quantity2" name="quantity2" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(2, 'Buffalo Milk', 35, 'quantity2')" class="buy-button">Buy Now</a>
        </div>

        <div class="product">
            <img src="new/milk.png" alt="Farm Fresh Toned Milk">
            <h3>Farm Fresh Toned Milk 1000ml</h3>
            <p>Farm Fresh Toned Milk 1000ml ₹60 / 1000ml</p>
            <p>Price: ₹60</p>
            <div class="quantity-selector">
                <label for="quantity3">Quantity:</label>
                <input type="number" id="quantity3" name="quantity3" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(3, 'Farm Fresh Toned Milk', 60, 'quantity3')" class="buy-button">Buy Now</a>
        </div>

        <div class="product">
            <img src="new/ghee.png" alt="Nature Cow Ghee">
            <h3>Nature Cow Ghee 500ml</h3>
            <p>Natural Cow Ghee ₹500 / 500ml</p>
            <p>Price:₹500</p>
            <div class="quantity-selector">
                <label for="quantity4">Quantity:</label>
                <input type="number" id="quantity4" name="quantity4" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(4, 'Nature Cow Ghee', 500, 'quantity4')" class="buy-button">Buy Now</a>
        </div>

        <div class="product">
            <img src="new/ghee.png" alt="Buffalo Ghee">
            <h3>Buffalo Ghee 500ml</h3>
            <p>Buffalo Ghee ₹400 / 500ml</p>
            <p>Price:₹400 </p>
            <div class="quantity-selector">
                <label for="quantity5">Quantity:</label>
                <input type="number" id="quantity5" name="quantity5" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(5, 'Buffalo Ghee', 400, 'quantity5')" class="buy-button">Buy Now</a>
        </div>

        <div class="product">
            <img src="new/panner.png" alt="Paneer">
            <h3>Paneer 200gms</h3>
            <p>Natural Paneer ₹100 / 200gms</p>
            <p>Price: ₹100</p>
            <div class="quantity-selector">
                <label for="quantity6">Quantity:</label>
                <input type="number" id="quantity6" name="quantity6" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(6, 'Paneer', 100, 'quantity6')" class="buy-button">Buy Now</a>
        </div>

        <div class="product">
            <img src="new/curd.png" alt="Curd">
            <h3>Curd 500gms</h3>
            <p>Thick Curd Pouch ₹38 / 500 gms</p>
            <p>Price: ₹38</p>
            <div class="quantity-selector">
                <label for="quantity7">Quantity:</label>
                <input type="number" id="quantity7" name="quantity7" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(7, 'Curd', 38, 'quantity7')" class="buy-button">Buy Now</a>
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