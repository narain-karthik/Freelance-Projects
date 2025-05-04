<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master_Page.Master" CodeBehind="Home.aspx.vb" Inherits="Dairy_Product_Management.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* General Styles */
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f5f5f5;
        }

        .container {
            display: flex;
            max-width: 1200px;
            margin: auto;
            padding: 20px;
            gap: 20px;
        }

        /* Left Section Styling */
        .left-section {
            flex: 2;
            background: url('background.jpg') no-repeat center center/cover;
            padding: 40px;
            text-align: center;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            color: #fff;
        }

        .left-section img {
            width: 150px;
            margin: 10px;
        }

        .left-section h1 {
            color: #fff;
            font-size: 36px;
            margin-bottom: 20px;
        }

        /* Right Section Styling */
        .right-section {
            flex: 1;
            display: flex;
            flex-direction: column;
            gap: 20px;
        }

        .offer-box {
            background: #ffebcd;
            padding: 20px;
            border-radius: 10px;
            text-align: center;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        .offer-box img {
            width: 80px;
            margin-bottom: 10px;
        }

        .offer-box h2 {
            color: #333;
            font-size: 20px;
            font-weight: 600;
        }

        .offer-box span {
            background: #ff9800;
            padding: 5px 15px;
            border-radius: 5px;
            color: white;
            font-weight: bold;
        }

        /* Products Section */
        .products-section {
            text-align: center;
            padding: 40px 0;
            background-color: #fff;
            border-top: 1px solid #ddd;
        }

        .products-section h2 {
            font-size: 28px;
            font-weight: bold;
            color: #333;
            margin-bottom: 20px;
        }

        .products-container {
            display: flex;
            justify-content: center;
            gap: 40px;
            flex-wrap: wrap;
            padding-top: 20px;
        }

        .product {
            text-align: center;
            flex-basis: 150px;
            background: #fafafa;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            transition: transform 0.3s ease;
        }

        .product:hover {
            transform: scale(1.05);
        }

        .product img {
            width: 100px;
            height: 100px;
            border-radius: 50%;
            border: 1px solid #ddd;
            padding: 10px;
            margin-bottom: 15px;
        }

        .product p {
            font-size: 16px;
            font-weight: bold;
            color: #333;
        }
        .left-section h1 {
    color: black; /* Change text color to black */
    font-size: 36px;
    margin-bottom: 20px;
}

    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <!-- Left Section -->
        <div class="left-section">
            <h1>Ghee as pure as our heritage</h1>
            <img src="new/ghee.png" alt="Buffalo Ghee">
            <img src="new/milk.png" alt="Cow Ghee">
        </div>

        <!-- Right Section -->
        <div class="right-section">
            <div class="offer-box">
                <img src="new/milk.png" alt="Milk">
                <h2>Pay for 28 days and Get 2 days <b>Milk Free</b></h2>
                <span>Use Code: Milk28</span>
            </div>
            <div class="offer-box">
                <img src="new/curd.png" alt="Curd">
                <h2>Pay for 27 days and Get 3 days <b>Curd Free</b></h2>
                <span>Use Code: Curd27</span>
            </div>
        </div>
    </div>

    <!-- Products Section -->
    <div class="products-section">
        <h2>All Farm Fresh Products At One Place...</h2>
        <div class="products-container">
            <div class="product">
                <img src="new/milk.png" alt="Milk" />
                <p>Milk</p>
            </div>
            <div class="product">
                <img src="new/ghee.png" alt="Ghee" />
                <p>Ghee</p>
            </div>
            <div class="product">
                <img src="new/panner.png" alt="Paneer" />
                <p>Paneer</p>
            </div>
            <div class="product">
                <img src="new/curd.png" alt="Curd" />
                <p>Curd</p>
            </div>
           
       
    </div>
</asp:Content>
