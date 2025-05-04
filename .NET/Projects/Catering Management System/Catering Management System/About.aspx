<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="About.aspx.vb" Inherits="Catering_Management_System.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Venus Catering Service - About Us</title>  <%-- Added a title --%>
    <style>
        body {
            font-family: sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
            color: #333;
        }

      .container {
            max-width: 960px;
            margin: 20px auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
        }

      .header {
            text-align: center;
            margin-bottom: 20px;
        }

      .header img { /* If you have a header image */
            max-width: 100%;
            height: auto;
        }

      .about-us {
            display: flex;
            flex-wrap: wrap;
            justify-content: center;
            align-items: center;
        }

      .image-column {
            flex: 1 1 300px;
            margin: 10px;
            text-align: center;
        }

      .image-column img {
            max-width: 100%;
            height: auto;
            border-radius: 8px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }

      .text-column {
            flex: 1 1 400px;
            margin: 10px;
        }

      .since {
            background-color: #d5d5d5;
            padding: 10px 20px;
            border-radius: 5px;
            margin-bottom: 10px;
            display: inline-block;
        }

      .book-now {
            display: inline-block;
            padding: 10px 20px;
            background-color: #ffcc00;
            color: #fff;
            text-decoration: none;
            border-radius: 5px;
            margin-top: 20px;
        }

      .book-now:hover {
            background-color: #ffb300;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="header">
            <%--  If you have a header image, uncomment and adjust the path --%>
            <%-- <asp:Image ID="HeaderImage" runat="server" ImageUrl="~/images/header.jpg" /> --%>  
            <h1> Catering Service</h1>
        </div>

        <div class="about-us">
            <div class="image-column">
                
                <asp:Image ID="CateringImage2" runat="server" ImageUrl="corporate.jpg" alt="Catering Image 2" />
            </div>

            <div class="text-column">
                <div class="since">Since 1998</div>
                <h2>Indulge in a celebration with great food!</h2>
                <p>atering Service is a professional catering company that was established in 1998, offering comprehensive services to meet all your culinary needs nearly two decades. Our primary goal is to provide a unique and memorable dining experience with each meal we serve. We are committed to maintaining uncompromised quality, exceptional hygiene standards, meticulous presentation and attention to detail to ensure the utmost satisfaction of our customers.</p>

                <asp:HyperLink ID="BookNowLink" runat="server" NavigateUrl="login.aspx" CssClass="book-now">Book Now</asp:HyperLink> <%-- ASP.NET Link --%>

            </div>
        </div>
    </div>
</asp:Content>