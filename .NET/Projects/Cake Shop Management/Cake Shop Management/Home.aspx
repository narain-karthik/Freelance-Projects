<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.vb" Inherits="Cake_Shop_Management.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;700&display=swap" rel="stylesheet">
    <style>
        body {
            font-family: 'Roboto', sans-serif; /* Updated font */
            text-align: center;
            margin: 0;
            padding: 0;
            background-color: #fff9e6; /* Light yellow background */
        }

        .container {
            display: flex;
            justify-content: center;
            align-items: center;
            flex-wrap: wrap;
            padding: 20px;
        }

        .category {
            margin: 30px;
            text-decoration: none;
            color: #ffcc00; /* Dark yellow color for text */
        }

        .image-wrapper {
            width: 150px;
            height: 150px;
            background-color: #fff;
            border-radius: 50%;
            overflow: hidden;
            display: flex;
            justify-content: center;
            align-items: center;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
            margin-bottom: 10px;
        }

        img {
            max-width: 100%;
            height: auto;
            display: block;
        }

        .category-name {
            color: #ffcc00; /* Dark yellow color for text */
            font-weight: bold;
            font-size: 16px;
            margin-top: 10px;
        }

        .banner {
            width: 100%;
            height: 200px;
            background-color: #ffcc00; /* Dark yellow banner */
            color: white;
            display: flex;
            justify-content: center;
            align-items: center;
            font-size: 24px;
            font-weight: bold;
        }

        .image-below-banner {
            width: 100%;
            text-align: center;
            margin-top: 20px;
        }

        .image-below-banner img {
            max-width: 1080px;
            width: 100%;
            height: auto;
        }

        /* New Styles for Cake Ordering Section */
        body {
            font-family: 'Roboto', sans-serif;
            margin: 0;
            padding: 0;
            background-color: #fff9e6; /* Light Yellow background */
        }

        .cakes {
            display: flex;
            justify-content: space-around;
            flex-wrap: wrap; /* Allows wrapping on smaller screens */
        }

        .cake {
            width: 22%; /* Adjust as needed for responsiveness */
            margin-bottom: 20px;
            border: 1px solid #ddd; /* Light border */
            padding: 10px;
            box-sizing: border-box; /* Ensures padding is included in width */
        }

        .cake img {
            max-width: 100%;
            height: auto;
            display: block; /* Prevents image from affecting layout */
            margin-bottom: 10px;
        }

        .cake h3 {
            margin-top: 0;
            color: #333;
        }

        .cake p {
            color: #666;
        }

        .view-more {
            text-align: center;
            margin-top: 20px;
        }

        .view-more a {
            display: inline-block;
            padding: 10px 20px;
            background-color: #ffcc00; /* Dark Yellow button */
            color: white;
            text-decoration: none;
            border-radius: 5px;
        }

        /* Hover effect for cake images */
        .cake:hover {
            transform: scale(1.05); /* Slight zoom effect on hover */
            transition: transform 0.3s ease;
        }

        /* Responsive adjustments */
        @media (max-width: 768px) {
            .cake {
                width: 45%; /* Two cakes per row on medium screens */
            }
        }
        @media (max-width: 480px) {
            .cake {
                width: 100%; /* One cake per row on small screens */
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Banner below the menu bar -->
    <div class="banner">
        <p>Welcome to Sweet Surrender Cake Shop! Your perfect cake awaits.</p>
    </div>

    <!-- Image below the banner -->
    <div class="image-below-banner">
        <center><img src="banner.png" alt="Delicious Cakes" /></center>
    </div>

    <div class="container">
        <a href="Menu.aspx" class="category">
            <div class="image-wrapper">
                <img src="logo/cake_logo.png" alt="Birthday Cakes">
            </div>
            <div class="category-name">Birthday Cakes</div>
        </a>

        <a href="Menu.aspx" class="category">
            <div class="image-wrapper">
                <img src="logo/couple.png" alt="Wedding Cakes">
            </div>
            <div class="category-name">Wedding Cakes</div>
        </a>

        <a href="Menu.aspx" class="category">
            <div class="image-wrapper">
                <img src="logo/glass.png" alt="Anniversary">
            </div>
            <div class="category-name">Anniversary</div>
        </a>

        <a href="Menu.aspx" class="category">
            <div class="image-wrapper">
                <img src="logo/horse.png" alt="Xpress Bees">
            </div>
            <div class="category-name">Xpress Bees</div>
        </a>

        <a href="Menu.aspx" class="category">
            <div class="image-wrapper">
                <img src="logo/gift.png" alt="Celebration Cakes">
            </div>
            <div class="category-name">Celebration Cakes</div>
        </a>
    </div>

    <!-- Cake Ordering Section -->
    <div class="cakes">
        <div class="cake">
            <img src="logo/l1.png" alt="TCS Xp 003 cake with Chocolate Roses decoration"/>
            <h3>Chocolate Roses</h3>
            
        </div>
        <div class="cake">
            <img src="logo/l2.png" alt="TCS Xp 004 cake with Sugar N Sparrow decoration"/>
            <h3>Sugar N Sparrow</h3>
            
        </div>
        <div class="cake">
            <img src="logo/l3.png" alt="TCS Xp 006 cake with Marble decoration"/>
            <h3>Marble</h3>
            
        </div>
        <div class="cake">
            <img src="logo/l4.png" alt="TCS Xp 0051 cake with Caramel decoration"/>
            <h3>Caramel</h3>
           
        </div>
    </div>
    <div class="view-more">
        <a href="Menu.aspx">VIEW MORE</a>
    </div>
</asp:Content>
