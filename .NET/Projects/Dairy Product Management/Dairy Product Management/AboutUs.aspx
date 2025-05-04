<%@ Page Title="About Us" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master_Page.Master" CodeBehind="AboutUs.aspx.vb" Inherits="Dairy_Product_Management.AboutUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Custom head elements (CSS, JS links, etc.) -->
    <style>
        /* General Body Styling */
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }

        /* Navigation Bar Styling */
        nav {
            background-color: #4CAF50;
            padding: 10px 0;
            text-align: center;
        }

        nav ul {
            list-style: none;
            padding: 0;
        }

        nav ul li {
            display: inline;
            margin-right: 20px;
        }

        nav ul li a {
            color: white;
            text-decoration: none;
            font-size: 18px;
        }

        nav ul li a:hover {
            text-decoration: underline;
        }

        /* Hero Section */
        .hero {
            text-align: center;
            margin: 20px 0;
        }

        .hero img {
            width: 100%;
            max-height: 400px;
            object-fit: cover;
        }

        /* About Sections */
        .about {
            padding: 40px;
            margin: 20px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
        }

        .about h2 {
            font-size: 28px;
            margin-bottom: 10px;
            color: #333;
        }

        .about p {
            font-size: 16px;
            color: #666;
            line-height: 1.6;
        }

        /* Products Section */
        .products {
            display: flex;
            justify-content: space-around;
            flex-wrap: wrap;
            padding: 40px;
            margin: 20px 0;
        }

        .product {
            text-align: center;
            margin: 15px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
            width: 150px;
            padding: 20px;
        }

        .product img {
            width: 100px;
            height: 100px;
            object-fit: contain;
            margin-bottom: 15px;
        }

        .product h3 {
            font-size: 18px;
            color: #333;
        }

    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav>
        <ul>
            <li><a href="#who-we-are">Who We Are</a></li>
            <li><a href="#our-mission">Our Mission</a></li>
            <li><a href="#our-vision">Our Vision</a></li>
        </ul>
    </nav>

    <div class="hero">
        <img src="image/hero.jpg" alt="Hero Image" />
    </div>

    <section class="about" id="who-we-are">
        <h2>Who We Are</h2>
        <p>We are a leading company in dairy production, committed to providing the best quality milk and dairy products. Our journey started with a mission to offer natural, fresh, and healthy dairy options for everyone.</p>
    </section>

    <section class="about" id="our-vision">
        <h2>Our Vision</h2>
        <p>Our aim is to meet the diverse needs of consumers every day by marketing and selling foods that are consistent and of high quality.</p>
    </section>

    <section class="about" id="our-mission">
        <h2>Our Mission</h2>
        <p>Our mission is to become the premier retailer of high-quality food products in India. To achieve this goal, we are committed to passionately focusing on customer value, being intolerant of waste, and serving as responsible citizens in our communities.</p>
    </section>

    <section class="products">
        
        <div class="product">
            <img src="new/curd.png" alt="Curd"/>
            <h3>Curd</h3>
        </div>
        <div class="product">
            <img src="new/milk.png" alt="Milk"/>
            <h3>Milk</h3>
        </div>
        <div class="product">
            <img src="new/ghee.png" alt="Ghee"/>
            <h3>Ghee</h3>
        </div>
        <div class="product">
            <img src="new/panner.png" alt="Paneer"/>
            <h3>Paneer</h3>
        </div>
    </section>

   
</asp:Content>
