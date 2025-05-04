<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.vb" Inherits="Digital_Catalog_for_Automobile.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;700&display=swap" rel="stylesheet">
    <style>
        body {
            font-family: 'Roboto', sans-serif; /* Updated font */
            text-align: center;
            margin: 0;
            padding: 0;
            background-color: #663399; /* Changed from light yellow #fff9e6 to purple */
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
            color: #663399; /* Changed from dark yellow #ffcc00 to purple */
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
            color: #663399; /* Changed from dark yellow #ffcc00 to purple */
            font-weight: bold;
            font-size: 16px;
            margin-top: 10px;
        }

        .banner {
            width: 100%;
            height: 200px;
            background-color: #663399; /* Changed from dark yellow #ffcc00 to purple */
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

        /* New Styles for Vehicle Catalog Section */
        body {
            font-family: 'Roboto', sans-serif;
            margin: 0;
            padding: 0;
            background-color: #663399; /* Changed from light yellow #fff9e6 to purple */
        }

        .vehicles {
            display: flex;
            justify-content: space-around;
            flex-wrap: wrap; /* Allows wrapping on smaller screens */
        }

        .vehicle {
            width: 22%; /* Adjust as needed for responsiveness */
            margin-bottom: 20px;
            border: 1px solid #ddd; /* Light border */
            padding: 10px;
            box-sizing: border-box; /* Ensures padding is included in width */
        }

        .vehicle img {
            max-width: 100%;
            height: auto;
            display: block; /* Prevents image from affecting layout */
            margin-bottom: 10px;
        }

        .vehicle h3 {
            margin-top: 0;
            color: #333;
        }

        .vehicle p {
            color: #666;
        }

        .view-more {
            text-align: center;
            margin-top: 20px;
        }

        .view-more a {
            display: inline-block;
            padding: 10px 20px;
            background-color: #663399; /* Changed from dark yellow #ffcc00 to purple */
            color: white;
            text-decoration: none;
            border-radius: 5px;
        }

        /* Hover effect for vehicle images */
        .vehicle:hover {
            transform: scale(1.05); /* Slight zoom effect on hover */
            transition: transform 0.3s ease;
        }

        /* Responsive adjustments */
        @media (max-width: 768px) {
            .vehicle {
                width: 45%; /* Two vehicles per row on medium screens */
            }
        }
        @media (max-width: 480px) {
            .vehicle {
                width: 100%; /* One vehicle per row on small screens */
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Banner below the menu bar -->
    <div class="banner">
        <p>Welcome to Automobile Store Discover Your Dream Ride.</p>
    </div>

    <!-- Image below the banner -->
    <div class="image-below-banner">
        <center><img src="banner.png" alt="Premium Vehicles" /></center>
    </div>

    <div class="container">
        <a href="Catalog.aspx" class="category">
            <div class="image-wrapper">
                <img src="brake.png" alt="Sedans">
            </div>
            <div class="category-name">Brake</div>
        </a>

        <a href="Catalog.aspx" class="category">
            <div class="image-wrapper">
                <img src="filters.png" alt="SUVs">
            </div>
            <div class="category-name">Filters</div>
        </a>

        <a href="Catalog.aspx" class="category">
            <div class="image-wrapper">
                <img src="disc.png" alt="Trucks">
            </div>
            <div class="category-name">Disc</div>
        </a>

        <a href="Catalog.aspx" class="category">
            <div class="image-wrapper">
                <img src="clutch.png" alt="Sports Cars">
            </div>
            <div class="category-name">Clutch</div>
        </a>

        <a href="Catalog.aspx" class="category">
            <div class="image-wrapper">
                <img src="spark.png" alt="Electric Vehicles">
            </div>
            <div class="category-name">Spark</div>
        </a>
    </div>

    <!-- Vehicle Catalog Section -->
    <div class="vehicles">
        <div class="vehicle">
            <img src="image/1.png" alt="Model A - Luxury Sedan"/>
            
        </div>
        <div class="vehicle">
            <img src="image/2.png" alt="Model B - Rugged SUV"/>
            
        </div>
        <div class="vehicle">
            <img src="image/3.png" alt="Model C - Heavy Duty Truck"/>
            
        </div>
        <div class="vehicle">
            <img src="image/4.png" alt="Model D - Performance Sports Car"/>
          
        </div>
    </div>
    <div class="view-more">
        <a href="Catalog.aspx">VIEW MORE</a>
    </div>
</asp:Content>