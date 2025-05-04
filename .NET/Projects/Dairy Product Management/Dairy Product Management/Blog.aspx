<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master_Page.Master" CodeBehind="Blog.aspx.vb" Inherits="Dairy_Product_Management.Blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Add the additional meta tags and styles here -->
    <meta name="description" content="Explore the latest editor's picks on dairy industry insights, recipes, and more.">
    <meta name="keywords" content="Indian government, dairy industry, Paneer Tikka Masala, homemade cheese">

    <style>
        /* Add styles inside the content, so they don't affect the master page */
        body {
            font-family: sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }

        .container {
            max-width: 960px;
            margin: 20px auto;
            padding: 20px;
        }

        .editors-pick {
            text-align: center;
            margin-bottom: 20px;
        }

        .editors-pick h2 {
            margin-bottom: 10px;
            color: #2c3e50;
        }

        .editors-pick p {
            color: #777;
            font-size: 16px;
        }

        .article-list {
            display: flex;
            gap: 20px;
            justify-content: center;
            flex-wrap: wrap;
        }

        .article {
            width: 300px;
            background-color: #fff;
            border-radius: 8px;
            overflow: hidden;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            transition: transform 0.3s ease-in-out, box-shadow 0.3s ease-in-out;
            margin-bottom: 20px;
        }

        .article:hover {
            transform: translateY(-10px);
            box-shadow: 0 6px 12px rgba(0, 0, 0, 0.1);
        }

        .article img {
            width: 100%;
            height: 200px;
            object-fit: cover;
        }

        .article-content {
            padding: 20px;
        }

        .article h3 {
            margin-bottom: 10px;
            color: #333;
            font-size: 18px;
        }

        .article p {
            color: #555;
            font-size: 14px;
            margin-bottom: 10px;
        }

        .article .date {
            color: #666;
            font-size: 12px;
        }

        @media (max-width: 768px) {
            .article-list {
                flex-direction: column;
            }
        }

        .image-area {
            position: relative;
            margin-bottom: 30px;
        }

        .image-area img {
            width: 100%;
            height: 400px;
            object-fit: cover;
            border-radius: 8px;
        }

        .overlay {
            position: absolute;
            top: 20200%;
            left: 50%;
            transform: translate(-50%, -50%);
            color: #fff;
            font-size: 24px;
            font-weight: bold;
            text-align: center;
            background-color: rgba(0, 0, 0, 0.5);
            padding: 20px;
            border-radius: 8px;
            margin-top: 0px;
        }

        .stats {
            position: absolute;
            bottom: 20px;
            right: 20px;
            color: #fff;
            font-size: 16px;
        }

        .stats .likes, .stats .comments {
            margin-right: 15px;
        }

        .content {
            margin-top: 20px;
        }

        .content .date {
            color: #777;
            font-size: 14px;
        }

        .content .article-title {
            font-size: 22px;
            color: #333;
            font-weight: bold;
            margin-top: 10px;
        }

        .content p {
            font-size: 16px;
            color: #555;
            margin-top: 10px;
        }

        .read-more {
            margin-top: 20px;
            display: inline-block;
            padding: 10px 20px;
            background-color: #3498db;
            color: #fff;
            text-decoration: none;
            border-radius: 5px;
            font-size: 16px;
        }

        .read-more:hover {
            background-color: #2980b9;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <!-- Editor's Pick Section -->
        <div class="editors-pick">
            <h2>Editor's Pick</h2>
            <p>Discover the most outstanding articles in all topics of life.</p>
        </div>

        <div class="article-list">
            <!-- Your HTML content here -->
            <div class="article">
                <img src="logo/blog.jpg" alt="How is the Indian Govt Currently Supporting the Dairy Industry">
                <div class="article-content">
                    <h3>How is the Indian Govt Currently Supporting the Dairy Industry</h3>
                    <p class="date">January 13, 2025</p>
                </div>
            </div>

            <div class="article">
                <img src="logo/blog 1.jpg" alt="Indulge in Farm-Fresh Goodness: Paneer Tikka Masala Recipe with Pravarsha Dairy's Best">
                <div class="article-content">
                    <h3>Indulge in Farm-Fresh Goodness: Paneer Tikka Masala Recipe with Pravarsha Dairy's Best</h3>
                    <p class="date">September 27, 2023</p>
                </div>
            </div>

            <div class="article">
                <img src="logo/blog2.jpg" alt="How to Make Cheese from Milk: A Delicious Homemade Recipe">
                <div class="article-content">
                    <h3>How to Make Cheese from Milk: A Delicious Homemade Recipe</h3>
                    <p class="date">September 21, 2023</p>
                </div>
            </div>
        </div>

        <!-- FSSAI Mandate Article Section -->
        <div class="container">
            <div class="image-area">
                <img src="image/blog5.jpg" alt="FSSAI Mandate on Milk Producers"/>
                <div class="overlay">
                    <h1>What is the New FSSAI Mandate<br>and How Does It Help the<br>Consumers?</h1>
                </div>
                <div class="stats">
                    &nbsp;</div>
            </div>
            <div class="content">
                <div class="date">December 19, 2024</div>
                <div class="article-title">Understanding the New FSSAI Mandate on Milk Producers</div>
                <p>The Food Safety and Standards Authority of India (FSSAI) has issued a recent notification mandating the registration of primary milk producers, aimed at ensuring safer milk production and better food safety practices. This mandate mainly focuses on...</p>
                <a href="#" class="read-more">Read More</a>
            </div>
        </div>

    </div>
</asp:Content>
