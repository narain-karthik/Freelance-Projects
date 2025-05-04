
<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="About.aspx.vb" Inherits="Digital_Catalog_for_Automobile.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* Container for the About section */
        .about-container {
            display: flex;
            width: 80%; /* Adjustable width */
            margin: 40px auto; /* Center with top/bottom spacing */
            padding: 20px;
            border: 1px solid #ccc; /* Subtle border */
            background-color: #f9f9f9; /* Light gray background for contrast */
            border-radius: 5px; /* Rounded corners */
        }

        /* Text content styling */
        .text-content {
            flex: 2; /* Takes up more space */
            padding-right: 20px;
            text-align: left; /* Left-align text for readability */
        }

        /* Image content styling */
        .image-content {
            flex: 1; /* Takes up less space */
        }

        .image-content img {
            max-width: 100%;
            height: auto;
            border-radius: 5px; /* Rounded corners for image */
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1); /* Subtle shadow */
        }

        /* Heading styling */
        h2 {
            text-align: center;
            margin: 20px 0;
            font-size: 28px; /* Slightly larger for emphasis */
        }

        /* Paragraph styling */
        p {
            line-height: 1.6; /* Improved readability */
            color: #333; /* Dark gray from Master page */
        }

        /* Highlighted text styles */
        .style1 {
            color: #663399; /* Purple from Master page */
            font-weight: bold;
        }

        .style2 {
            color: #663399; /* Purple from Master page */
            font-style: italic;
            font-weight: bold;
        }

        /* Responsive adjustments */
        @media (max-width: 768px) {
            .about-container {
                flex-direction: column; /* Stack vertically on smaller screens */
                width: 90%; /* Slightly wider on mobile */
            }

            .text-content {
                padding-right: 0;
                margin-bottom: 20px; /* Space between text and image */
            }

            .image-content {
                text-align: center; /* Center image on mobile */
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="style1">About Auto Haven</h2>
    <div class="about-container">
        <div class="text-content">
            <p>We at <span class="style1">Auto Haven</span> specialize in premium vehicles. We believe in 
                <span class="style2">"Quality in Every Drive"</span>, sourcing the finest models globally to deliver an ultimate driving experience that 
                <span class="style2">"Puts a Smile on Your Journey"</span>.</p>
            <p>Our vehicles are renowned for their quality and come with a wide range of exclusive features and customization options.</p>
            <p>From custom-designed cars to rugged trucks and sleek SUVs, we cater to enthusiasts, making every ride unique and unforgettable. We take pride in understanding our customers’ expectations.</p>
            <p>That’s why we perfectly personalize each vehicle to meet your needs.</p>
        </div>
        <div class="image-content">
            <img src="about.jpg" alt="Inside Auto Haven Showroom" />
        </div>
    </div>
</asp:Content>
