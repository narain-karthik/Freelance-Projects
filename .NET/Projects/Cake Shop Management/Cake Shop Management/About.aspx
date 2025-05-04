<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="About.aspx.vb" Inherits="Cake_Shop_Management.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /*... (CSS styles from previous response go here)... */
        
        .container {
            display: flex;
            width: 80%; /* Adjust as needed */
            border: 1px solid #ccc; /* Optional border */
            padding: 20px;
        }
        .text-content {
            flex: 2; /* Adjust the ratio as needed */
            padding-right: 20px;
        }
        .image-content {
            flex: 1; /* Adjust the ratio as needed */
        }
        .image-content img {
            max-width: 100%;
            height: auto;
        }
        h2 {
            text-align: center;
        }
        .highlight {
            font-style: italic;
        }
        /* Responsive adjustments */
        @media (max-width: 768px) {
            .container {
                flex-direction: column;
            }
            .text-content {
                padding-right: 0;
                margin-bottom: 20px;
            }
        }
        .style1
        {
            color: #FFD700;
        }
        .style2
        {
            font-style: italic;
            color: #FFD700;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="style1">ABOUT CAKE SHOP</h2>
    <div class="container">
        <div class="text-content">
            <p>We at <span class="style1"><strong>The Cake Shop</strong></span> specialize in Desserts &amp; Cakes, we believe in 
                <span class="style2"><strong>"Quality in our Edge"</strong></span>, from selecting the ingredients around India to the final exquisite creation that 
                <span class="style2"><strong>"Bring you smiles for Sure"</strong></span>.</p>
            <p>Our cakes &amp; Desserts receive a lot of compliments and are complimented by a wide range of exclusive desserts.</p>
            <p>Our theme based Creative Cakes, Cake pop, Cup Cakes and Desserts for Parties, make your Party Unique and Inevitable. We spend more time in understanding customers expectation.</p>
            <p>So we Perfectly Personalize to the Needs.</p>
        </div>
        <div class="image-content">
            <img src="about.png" alt="Inside Kitchen">
        </div>
    </div>
</asp:Content>