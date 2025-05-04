<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Service.aspx.vb" Inherits="Courier_Management_System.Service" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Additional Meta Tags for SEO and Social Sharing -->
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Explore our B2C Courier services and the industries we serve, including consumer electronics, eCommerce, pharmaceuticals, fashion, and more.">
    <meta property="og:title" content="B2C Courier Services - Industries We Serve">
    <meta property="og:description" content="Discover how our courier services benefit industries like eCommerce, consumer electronics, and pharmaceuticals, ensuring fast, reliable, and secure deliveries.">
    <meta property="og:image" content="image1.jpg">
    <meta name="twitter:title" content="B2C Courier Services - Industries We Serve">
    <meta name="twitter:description" content="Reliable and secure courier solutions for industries such as eCommerce, pharmaceuticals, and more.">
    <meta name="twitter:image" content="image1.jpg">
    <style>
        /* Light Red Background for Sections */
        .container {
            display: flex;
            flex-wrap: wrap;
            justify-content: space-around;
            margin: 20px;
        }

        .box {
            background-color: #ffcccc; /* Light red background */
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1); /* Subtle shadow */
            width: 45%;
            margin: 10px 0;
            text-align: center;
        }

        .box img {
            max-width: 100%;
            height: auto;
            border-radius: 8px;
        }

        .box h2 {
            font-size: 1.5em;
            color: #333;
        }

        .box p, .box ul {
            color: #666;
            font-size: 1.1em;
        }

        .box ul {
            list-style-type: none;
            padding-left: 0;
        }

        .box ul li {
            margin-bottom: 8px;
        }

        h1 {
            text-align: center;
            color: #333;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Why Choose Us?</h1>

    <div class="container">
        <div class="box">
            <div class="image-container">
                <img src="w1.png" alt="Fast Delivery Solutions">
            </div>
            <h2>Express Solutions for Super-Fast Deliveries</h2>
            <p>Our Express Solutions provide a lightning-fast delivery option that caters to urgent shipments, ensuring your customers receive their orders at lightning speed.</p>
        </div>

        <div class="box">
            <div class="image-container">
                <img src="w2.png" alt="Cost-Effective Pricing">
            </div>
            <h2>Cost-Effective Pricing</h2>
            <p>We believe in transparent and competitive pricing, delivering exceptional value without compromising on service quality.</p>
        </div>

        <div class="box">
            <div class="image-container">
                <img src="w3.png" alt="Value-Added Services">
            </div>
            <h2>Value-Added Services</h2>
            <p>We provide value-added services such as cash on delivery (COD), reverse logistics, multi-SKU, self-collect, self-drop, open delivery, and quality checks, offering a comprehensive suite of solutions to meet your needs.</p>
        </div>

        <div class="box">
            <div class="image-container">
                <img src="w4.png" alt="Industry Expertise">
            </div>
            <h2>Industry Expertise</h2>
            <p>With extensive experience in the logistics industry with over 650+ clients, we understand the unique requirements of various sectors, tailoring solutions to meet your specific needs.</p>
        </div>
    </div>

    <h1>Industries Which Benefit From Our B2C Courier Services</h1>

    <div class="container">
        <div class="box">
            <div class="image-container">
                <img src="b1.jpg" alt="Consumer Electronics">
            </div>
            <h2>Consumer Electronics</h2>
            <ul>
                <li>Specialized Handling for Fragile Items</li>
                <li>Nationwide reach to over 20000 pincodes</li>
            </ul>
        </div>

        <div class="box">
            <div class="image-container">
                <img src="b2.jpg" alt="eCommerce">
            </div>
            <h2>eCommerce</h2>
            <ul>
                <li>Efficient Returns Management</li>
                <li>Extensive Reach to 20000+ pincodes</li>
                <li>Industry Expertise with over 650+ clients</li>
            </ul>
        </div>

        <div class="box">
            <div class="image-container">
                <img src="b3.jpg" alt="Pharmaceuticals">
            </div>
            <h2>Pharmaceuticals</h2>
            <ul>
                <li>Specialized Handling for Fragile Items</li>
                <li>Same-day and Next day-delivery option</li>
            </ul>
        </div>

        <div class="box">
            <div class="image-container">
                <img src="b4.jpg" alt="Fashion and Apparel">
            </div>
            <h2>Fashion and Apparel</h2>
            <ul>
                <li>Express Shipping solutions</li>
                <li>Scalability for Seasonal Peaks</li>
                <li>COD and UPI Payment Solutions</li>
                <li>Multi-SKU Handling Service</li>
            </ul>
        </div>

        <div class="box">
            <div class="image-container">
                <img src="b5.jpg" alt="Banking and Finance">
            </div>
            <h2>Banking and Finance</h2>
            <ul>
                <li>OTP verified Secure Deliveries</li>
                <li>Dedicated Handling of Sensitive Information</li>
                <li>Regulatory Compliance</li>
            </ul>
        </div>

        <div class="box">
            <div class="image-container">
                <img src="b6.jpg" alt="Consumer Goods and FMCG">
            </div>
            <h2>Consumer Goods and FMCG</h2>
            <ul>
                <li>Multi-channel fulfillment</li>
                <li>Multi-modal transportation</li>
            </ul>
        </div>
    </div>
</asp:Content>

