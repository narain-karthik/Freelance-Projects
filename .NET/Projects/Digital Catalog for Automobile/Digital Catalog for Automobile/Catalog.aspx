<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Catalog.aspx.vb" Inherits="Digital_Catalog_for_Automobile.Catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .product-container {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            grid-gap: 25px; /* Slightly increased for spacing */
            padding: 30px;
            max-width: 1200px;
            margin: 0 auto; /* Centered */
        }

        .product {
            border: 1px solid #ccc;
            padding: 20px;
            text-align: center;
            box-shadow: 2px 2px 8px rgba(0, 0, 0, 0.1); /* Slightly stronger shadow */
            border-radius: 8px;
            transition: transform 0.2s ease, box-shadow 0.2s ease;
            background-color: #f9f9f9; /* Light gray background */
        }

        .product:hover {
            transform: scale(1.05);
            box-shadow: 4px 4px 12px rgba(0, 0, 0, 0.15); /* Enhanced hover shadow */
        }

        .product img {
            max-width: 100%;
            height: auto;
            margin-bottom: 15px;
            border-radius: 4px;
            object-fit: cover; /* Ensures image fits nicely */
        }

        .product h3 {
            margin-bottom: 8px;
            color: #333; /* Dark gray from Master page */
            font-size: 1.2em;
        }

        .product p {
            margin-bottom: 10px;
            color: #666; /* Medium gray */
            font-size: 0.95em;
        }

        .quantity-selector {
            display: flex;
            align-items: center;
            justify-content: center;
            margin-bottom: 15px;
        }

        .quantity-input {
            width: 50px;
            padding: 6px;
            margin-left: 8px;
            border: 1px solid #ccc;
            border-radius: 4px;
            text-align: center;
            font-size: 0.9em;
        }

        .buy-button {
            display: inline-block;
            padding: 10px 20px;
            background-color: #663399; /* Changed from #007bff (blue) to #663399 (purple) */
            color: white;
            text-decoration: none;
            border-radius: 5px;
            transition: background-color 0.3s ease, transform 0.2s ease;
            margin-top: 10px;
            font-weight: 600;
        }

        .buy-button:hover {
            background-color: #552288; /* Darker purple for hover (replaced #0056b3) */
            transform: translateY(-2px); /* Slight lift effect */
        }

        .style1 {
            color: #663399; /* Changed from #FFD700 (yellow) to #663399 (purple) */
        }

        /* Responsive adjustments */
        @media (max-width: 768px) {
            .product-container {
                padding: 15px;
            }
            .product h3 {
                font-size: 1.1em;
            }
            .product p {
                font-size: 0.9em;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1 class="style1">Select Your Vehicle</h1></center>
    <div class="product-container">
        <div class="product">
            <img src="image/p1.png" alt="Luxury Sedan">
            <h3>Oil Filter</h3>
            <p>Oil Filter K2MZ6731B – Fits Ford Fiesta / Figo (Dsl)</p>
            <p>Price: ₹396</p>
            <div class="quantity-selector">
                <label for="quantity1">Quantity:</label>
                <input type="number" id="quantity1" name="quantity1" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(1, 'Oil Filter', 396, 'quantity1')" class="buy-button">Add to Cart</a>
        </div>

        <div class="product">
            <img src="image/p2.png" alt="Rugged SUV">
            <h3>Brake Pad</h3>
            <p>Brembo Front Brake Pad (Set) P54030 – Fits Mitsubishi Outlander (Type 2 ) / Cedia</p>
            <p>Price: ₹3,038</p>
            <div class="quantity-selector">
                <label for="quantity2">Quantity:</label>
                <input type="number" id="quantity2" name="quantity2" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(2, 'Brake Pad', 3038, 'quantity2')" class="buy-button">Add to Cart</a>
        </div>

        <div class="product">
            <img src="image/p3.png" alt="Heavy Duty Truck">
            <h3>Rear Brake Shoe </h3>
            <p>Rear Brake Shoe (ABS) (Set) 6N2Z2200A – Fits Ford Figo / Fiesta (Type 1) / Fusion / Ikon</p>
            <p>Price: ₹1,580</p>
            <div class="quantity-selector">
                <label for="quantity3">Quantity:</label>
                <input type="number" id="quantity3" name="quantity3" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(3, 'Rear Brake Shoe ', 1580, 'quantity3')" class="buy-button">Add to Cart</a>
        </div>

        <div class="product">
            <img src="image/p4.png" alt="Performance Sports Car">
            <h3>Front Disc</h3>
            <p>Brembo Front Disc Rotor (Drilled) (Set) 09.7011.1X – Fits VW Ameo / Polo / Vento</p>
            <p>Price: ₹11,974</p>
            <div class="quantity-selector">
                <label for="quantity4">Quantity:</label>
                <input type="number" id="quantity4" name="quantity4" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(4, 'Front Disc', 11974, 'quantity4')" class="buy-button">Add to Cart</a>
        </div>

        <div class="product">
            <img src="image/p5.png" alt="Electric SUV">
            <h3>Clutch Set </h3>
            <p>Clutch Set (Clutch & Pressure Plate) 8V2Z7B546V – Fits Ford Ecosport / Figo / Fiesta (T2) / Figo Aspire (Dsl)</p>
            <p>Price: ₹5,029</p>
            <div class="quantity-selector">
                <label for="quantity5">Quantity:</label>
                <input type="number" id="quantity5" name="quantity5" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(5, 'Clutch Set ', 5029, 'quantity5')" class="buy-button">Add to Cart</a>
        </div>

        <div class="product">
            <img src="image/p6.png" alt="Compact Sedan">
            <h3>Red Grill Hor</h3>
            <p>Hella Red Grill Horn (Set) – 003.399-842</p>
            <p>Price: ₹1,675</p>
            <div class="quantity-selector">
                <label for="quantity6">Quantity:</label>
                <input type="number" id="quantity6" name="quantity6" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(6, 'Red Grill Hor', 1675, 'quantity6')" class="buy-button">Add to Cart</a>
        </div>

        <div class="product">
            <img src="image/p7.png" alt="Family SUV">
            <h3>Spark Plug</h3>
            <p>NGK Conventional Spark Plug (Set of 4) LKR6D-10E – Fits HY I10 / I20 (Kappa)</p>
            <p>Price: ₹925</p>
            <div class="quantity-selector">
                <label for="quantity7">Quantity:</label>
                <input type="number" id="quantity7" name="quantity7" value="1" min="1" class="quantity-input">
            </div>
            <a href="#" onclick="addToCart(7, 'Spark Plug', 925, 'quantity7')" class="buy-button">Add to Cart</a>
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