<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="AboutUs.aspx.vb" Inherits="Courier_Management_System.AboutUs" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- CSS Styling for Mission, Vision, and Core Values -->
    <style>
        body {
            font-family: sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4; /* Light background color */
            color: #333; /* Dark text color for contrast */
        }

       .container {
    max-width: 960px;
    margin: 20px auto;
    padding: 20px;
    background-color: #ffcccc; /* Light red container background */
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); /* Subtle shadow */
    border-radius: 8px; /* Rounded corners */
}


        .block {
            background-color: #fff;
            padding: 40px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            text-align: left; /* Align text to the left */
            width: 45%; /* Occupy 45% of the container width */
            margin: 10px; /* Add some margin between the blocks */
        }

        .block h2 {
            color: #333;
            margin-bottom: 20px;
        }

        .block p {
            color: #666;
            line-height: 1.6;
        }

        /* Core Values Grid Layout */
        h1 {
            text-align: center;
            margin-bottom: 20px;
            color: #007bff; /* Blue heading color */
        }

        .values-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr)); /* Responsive columns */
            grid-gap: 20px;
        }

        .value-card {
            padding: 20px;
            border: 1px solid #eee; /* Light border */
            border-radius: 8px;
            text-align: center; /* Center icon and text */
            transition: transform 0.2s ease, box-shadow 0.2s ease; /* Smooth transitions */
            background-color: #fff; /* Card background */
        }

        .value-card:hover {
            transform: translateY(-5px); /* Move up on hover */
            box-shadow: 0 5px 15px rgba(0, 0, 0, 0.15); /* More prominent shadow */
        }

        .value-icon {
            margin-bottom: 15px;
        }

        .icon-image {
            width: 60px; /* Set the width of the icon */
            height: 60px; /* Set the height of the icon */
            object-fit: cover; /* Ensure the image doesn't get distorted */
            border-radius: 50%; /* Make the image circular */
        }

        .value-title {
            font-weight: bold;
            margin-bottom: 10px;
        }

        .value-description {
            font-size: 14px;
            color: #666; /* Slightly lighter text for description */
        }

        /* Responsive adjustments */
        @media (max-width: 768px) {
            .block {
                width: 90%; /* On smaller screens, make blocks occupy more width */
                margin: 10px 0; /* Reduce horizontal margins */
                padding: 20px; /* Reduce padding */
            }
        }
        /* Timeline Styles */
        .timeline-container {
            width: 80%;
            margin: 20px auto;
            background-color: white;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
        }

        .timeline {
            display: flex;
            align-items: center;
            justify-content: space-between;
            margin-bottom: 30px;
            position: relative;
        }

        .line {
            position: absolute;
            top: 50%;
            left: 5%;
            transform: translateY(-50%);
            width: 90%;
            height: 2px;
            background-color: #ccc;
            z-index: 1;
        }

        .circle {
            width: 20px;
            height: 20px;
            border-radius: 50%;
            background-color: #ccc;
            z-index: 2;
            cursor: pointer;
            transition: background-color 0.3s;
        }

        .circle:hover {
            background-color: #333;
        }

        .circle.active {
            background-color: #f96302; /* Orange */
        }

        .milestone-content {
            background-color: #fff8ef; /* Light yellow */
            padding: 20px;
            margin-bottom: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
            display: none;
        }

        .milestone-content.active {
            display: block;
        }

        .milestone-content h2 {
            margin-top: 0;
        }

        .year {
            font-size: 1.2em;
            color: #666;
        }
        .style1
        {
            text-align: center;
            color: #FF4D4D;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Mission and Vision Section -->
    <h2 class="style1">About Us</h2>
    <div class="container">
        <div class="block">
            <h2>Our Mission</h2>
            <p>Our mission at XpressBees Logistics is to excel as the most cost-effective service provider and capital-efficient company while simultaneously establishing our position as the foremost logistics partner within the industry.</p>
        </div>
        <div class="block">
            <h2>Our Vision</h2>
            <p>Our vision is to make XpressBees Logistics the foremost choice for logistics services in the nation, offering unmatched solutions and an exceptional delivery experience.</p>
        </div>
    </div>

    <!-- Core Values Section -->
    <div class="container">
        <h1>Our Core Values</h1>

        <div class="values-grid">
            <!-- Integrity -->
            <div class="value-card">
                <div class="value-icon">
                    <img src="n1.png" alt="Integrity Icon" class="icon-image" />
                </div>
                <div class="value-title">Integrity</div>
                <div class="value-description">Upholding unwavering honesty and ethical principles, fostering trust and respect</div>
            </div>
            
            <!-- Passion for Excellence -->
            <div class="value-card">
                <div class="value-icon">
                    <img src="n3.png" alt="Passion for Excellence Icon" class="icon-image" />
                </div>
                <div class="value-title">Passion for Excellence</div>
                <div class="value-description">Relentlessly pursuing the highest standards, igniting growth and innovation</div>
            </div>

            <!-- Innovation & Learning -->
            <div class="value-card">
                <div class="value-icon">
                    <img src="n4.png" alt="Innovation & Learning Icon" class="icon-image" />
                </div>
                <div class="value-title">Innovation & Learning</div>
                <div class="value-description">Embracing change, fueling growth through continuous exploration and improvement</div>
            </div>

            <!-- Customer First -->
            <div class="value-card">
                <div class="value-icon">
                    <img src="n5.png" alt="Customer First Icon" class="icon-image" />
                </div>
                <div class="value-title">Customer First</div>
                <div class="value-description">Dedication to exceed expectations, delivering exceptional solutions and experiences</div>
            </div>

            <!-- Confidence & Respect -->
            <div class="value-card">
                <div class="value-icon">
                    <img src="n6.png" alt="Confidence & Respect Icon" class="icon-image" />
                </div>
                <div class="value-title">Confidence & Respect</div>
                <div class="value-description">Valuing self-assurance and treating all with dignity and esteem</div>
            </div>

            <!-- Building a Community -->
            <div class="value-card">
                <div class="value-icon">
                    <img src="n7.png" alt="Building a Community Icon" class="icon-image" />
                </div>
                <div class="value-title">Building a Community</div>
                <div class="value-description">Fostering connections, collaboration, and shared growth through unity</div>
            </div>
        </div>

    </div>
</asp:Content>
