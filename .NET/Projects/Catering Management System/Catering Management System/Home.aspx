<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.vb" Inherits="Catering_Management_System.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            font-family: sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }

        .banner {
            background-image: url('banner.jpg'); /* **REPLACE with your image path** */
            background-size: cover;
            background-position: center;
            height: 300px; /* Adjust as needed */
            color: white;
            text-align: center;
            display: flex; /* Use flexbox for centering */
            flex-direction: column;
            justify-content: center; /* Vertically center content */
            align-items: center; /* Horizontally center content */
        }

        .banner h1 {
            font-size: 3em;
            margin-bottom: 20px;
            text-shadow: 2px 2px 4px rgba(0,0,0,0.3); /* Add a text shadow */

        }

        .banner p {
            font-size: 1.2em;
            text-shadow: 2px 2px 4px rgba(0,0,0,0.3); /* Add a text shadow */
        }

        .container {
            max-width: 960px;
            margin: 20px auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h2 {
            text-align: center;
            margin-bottom: 20px;
            color: #333;
        }

        .services {
            display: flex;
            justify-content: space-between;
            flex-wrap: wrap;
        }

        .service {
            width: 32%;
            margin-bottom: 20px;
            background-color: #fff;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
            border-radius: 5px;
            overflow: hidden;
        }

        .service img {
            width: 100%;
            height: auto;
            display: block;
        }

        .service-content {
            padding: 20px;
        }

        .service h3 {
            margin-top: 0;
            color: #333;
        }

        .service p {
            color: #666;
            line-height: 1.6;
        }

        .view-all {
            text-align: center;
            margin-top: 20px;
        }

        .view-all a {
            display: inline-block;
            padding: 10px 20px;
            background-color: #d3b04c;
            color: #fff;
            text-decoration: none;
            border-radius: 5px;
        }

        @media (max-width: 768px) {
            .service {
                width: 48%;
            }
        }

        @media (max-width: 500px) {
            .service {
                width: 100%;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="banner">
        
    </div>

    <div class="container">
        <h2>Premium catering services</h2>

        <div class="services">
            <div class="service">
                <img src="wedding.jpg" alt="Wedding Event">
                <div class="service-content">
                    <h3>Wedding Event</h3>
                    <p>We are here to make a memorable experience for your guests by pampering their taste buds.</p>
                </div>
            </div>
            <div class="service">
                <img src="corporate.jpg" alt="Corporate Event">
                <div class="service-content">
                    <h3>Corporate Event</h3>
                    <p>We focus on delivering the customized delicacies of different types. We make sure all the audience feel good about the food too and that make your event unique.</p>
                </div>
            </div>
            <div class="service">
                <img src="birthday.jpg" alt="Birthday Party">
                <div class="service-content">
                    <h3>Birthday Party</h3>
                    <p>At Venus Catering Service, we take care of the happiness of your guests by offering them amazing food on behalf of you.</p>
                </div>
            </div>
        </div>

        <div class="view-all">
            <a href="#">View All Services</a>
        </div>
    </div>
</asp:Content>