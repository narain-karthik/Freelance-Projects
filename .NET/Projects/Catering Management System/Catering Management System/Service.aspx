<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Service.aspx.vb" Inherits="Catering_Management_System.Service" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            font-family: sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4; /* Light gray background */
        }
        .container {
            max-width: 960px;
            margin: 20px auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        h1 {
            text-align: center;
            margin-bottom: 20px;
        }
        .event-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr)); /* Responsive columns */
            grid-gap: 20px;
        }
        .event {
            border: 1px solid #ddd;
            padding: 20px;
            text-align: center;
        }
        .event img {
            max-width: 100%;
            height: auto;
            margin-bottom: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Premium Catering Services</h1>
        <div class="event-grid">
            <div class="event">
                <img src="wedding.jpg" alt="Wedding Event">
                <h2>Wedding Event</h2>
                <p>Wedding. Why we have the concept of inviting all our relatives, friends and known ones? Its because, when a family celebrates an event means, its an occasion, when lot of people celebrates an event means, it turns as a feast. If there any feast occurs without food?? We are here to make a memorable experience for your guests by pampering their taste buds.</p>
            </div>
            <div class="event">
                <img src="corporate.jpg" alt="Corporate Event">
                <h2>Corporate Event</h2>
                <p>From corporate events to business occasions or milestone celebrations, our event catering team captures the heart of their audiences on their special occasions. We focus on delivering the customized delicacies of different types. We make sure all the audience feel good about the food too and that make your event unique.</p>
            </div>
            <div class="event">
                <img src="birthday.jpg" alt="Birthday Party">
                <h2>Birthday Party</h2>
                <p>Make every birthday a memorable one with our birthday photography. Whether it’s a child's first birthday or a milestone celebration, we capture the joy, excitement, and love of the day and preserve it forever. At Venus Catering Service, we take care of the happiness of your guests by offering them amazing food on behalf of you.</p>
            </div>
            <div class="event">
                <img src="retirement.jpg" alt="Retirement">
                <h2>Retirement</h2>
                <p>A retirement party is definitely a time to get emotional and relish the moments of hard work and perseverance. We do this by organizing an event to present highlights of the retiree's personal life and work life. Both are important to display at this occasion. We call all our colleagues and near ones and its unfair to send them without good food.</p>
            </div>
            <div class="event">
                <img src="engagement.jpg" alt="Engagement">
                <h2>Engagement</h2>
                <p>Wedding is a special bond which makes the life of any person as a beautiful one. Engagement is the first step of the wedding process and it assures the bond and relationship between two individuals. Engagements are celebrated in very grand manner. According to us, we give more importance to the satisfaction of the guests in terms of food.</p>
            </div>
            <div class="event">
                <img src="housewarming.jpg" alt="House Warming">
                <h2>House Warming</h2>
                <p>Houses makes our life complete. Most of our life we are going to spend on the houses. So houses are always special. It carries out all the emotions of family and pass it to generations and on. In our society, building a house is considered as an achievement and it gives immense happiness and secured feel. We take of your guests and they will praise about your house and our food as well.</p>
            </div>
        </div>
    </div>
</asp:Content>