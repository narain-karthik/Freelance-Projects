<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.vb" Inherits="Courier_Management_System.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* Tracking Section Styles */
        .tracking-container {
    max-width: 960px;
    margin: 20px auto;
    padding: 20px;
    background-color: #ffcccc; /* Light red background */
    box-shadow: 0 4px 12px rgba(0, 0, 0, 0.1);
    border-radius: 10px;
}


        .ship-enquire {
            display: flex;
            justify-content: space-between;
            margin-bottom: 20px;
        }

       .ship-enquire a {
    background-color: #ff4d4d; /* Match header red */
    color: white;
    padding: 12px 25px;
    border-radius: 5px;
    text-decoration: none;
    font-weight: bold;
    text-align: center;
    transition: background-color 0.3s ease;
}

.ship-enquire a:hover {
    background-color: #e64d4d; /* Slightly darker red for hover */
}


        .track-form {
    background-color: #ffcccc; /* Light red background */
    padding: 30px;
    border-radius: 8px;
    margin-bottom: 20px;
}


        .form-title {
            color: white;
            font-size: 1.5em;
            margin-bottom: 20px;
            text-align: center;
        }

        .input-group {
            display: flex;
            margin-bottom: 15px;
        }

        .input-group label {
            padding: 12px 15px;
            background-color: #eee;
            border: 1px solid #ddd;
            border-right: none;
            width: 30%;
        }

        .input-group input {
            flex: 1;
            padding: 12px;
            border: 1px solid #ddd;
            border-left: none;
            border-radius: 5px;
            font-size: 1em;
        }

       .submit-btn {
    background-color: #ff4d4d; /* Match header red */
    color: white;
    padding: 12px 25px;
    border: none;
    border-radius: 5px;
    cursor: pointer;
    width: 100%;
    font-size: 1.1em;
    transition: background-color 0.3s ease;
}

.submit-btn:hover {
    background-color: #e64d4d; /* Slightly darker red for hover */
}

        
        /* Why Choose Section */
        .why-choose {
            text-align: center;
            margin-bottom: 30px;
        }

        .features {
            display: flex;
            flex-wrap: wrap;
            justify-content: space-around;
            gap: 20px;
        }

        .feature {
            text-align: center;
            flex-basis: 30%;
            margin-bottom: 30px;
        }

        .feature img {
            max-width: 100px;
            margin-bottom: 15px;
            transition: transform 0.3s ease;
        }

        .feature:hover img {
            transform: scale(1.1); /* Slight zoom effect on hover */
        }

        .feature p {
            font-size: 1.1em;
            font-weight: bold;
        }
        .container {
            max-width: 960px;
            margin: 20px auto;
            padding: 20px;
        }
        .grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            grid-gap: 20px;
        }
        .card {
    background-color: #ffcccc; /* Light red background */
    border-radius: 8px;
    padding: 20px;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
}

        .card img {
            width: 50px;
            height: 50px;
            margin-bottom: 10px;
        }
        .card h2 {
            margin-top: 0;
            font-size: 1.2em;
        }
        .card p {
            color: #666;
            line-height: 1.6;
        }
        .read-more {
            display: inline-block;
            padding: 8px 16px;
            background-color: #007bff;
            color: #fff;
            text-decoration: none;
            border-radius: 4px;
            margin-top: 10px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function showAlert(message) {
            alert(message);
        }
    </script>

    <div class="tracking-container">
        <div class="ship-enquire">
            <a href="login.aspx">Ship Now</a>
            <a href="Enquire.aspx">Enquire Now</a>
        </div>

        <div class="track-form">
            <h2 class="form-title">Track Your Shipment</h2>
            <div class="input-group">
                <label for="awb">AWB No.</label>
                <asp:TextBox ID="awb" runat="server" CssClass="form-control" TextMode="SingleLine" />
            </div>
            <asp:Button ID="btnTrack" runat="server" CssClass="submit-btn" Text="Track" OnClick="btnTrack_Click" />
        </div>
        <div class="why-choose">
            <h2>Why choose Courier</h2>
            <div class="features">
                <div class="feature">
                    <img src="image/l1.jpg" alt="3million+ Shipments/Day">
                    <p>3million +<br>Shipments/Day</p>
                </div>
                <div class="feature">
                    <img src="image/l2.jpg" alt="150+ Hubs">
                    <p>150+<br>Hubs</p>
                </div>
                <div class="feature">
                    <img src="image/l3.jpg" alt="3,500+ Service Centres">
                    <p>3,500+<br>Service Centres</p>
                </div>
                <div class="feature">
                    <img src="image/l4.jpg" alt="20,000+ Pin Codes">
                    <p>20,000+<br>Pin Codes</p>
                </div>
                <div class="feature">
                    <img src="image/l5.jpg" alt="28,000+ Field Service Representatives">
                    <p>28,000+<br>Field Service Representatives</p>
                </div>
                <div class="feature">
                    <img src="image/l6.jpg" alt="52+ Cargo Airports">
                    <p>52+<br>Cargo Airports</p>
                </div>
            </div>
        </div>
         <div class="container">
        <div class="grid">
            <div class="card">
                <img src="r1.png" alt="Domestic"> 
                <h2>Domestic</h2>
                <p>Domestic shipping, often known as a domestic courier, refers to sending an item through a carrier within the boundaries of a nation. Domestic courier businesses provide options for domestic shipping based on the contents, volume, and urgency of the recipient's packages.</p>
                <a href="#" class="read-more">Read More</a>
            </div>
            <div class="card">
                <img src="r2.png" alt="International">
                <h2>International</h2>
                <p>We are provided extensive service at action of consigning and done for your shipping. We are specialists for international courier services, door to door services, express parcel and packages services with easy to shipping and tracking for your goods. Time definite and quick delivery services to more than 220 Countries.</p>
                <a href="#" class="read-more">Read More</a>
            </div>
            <div class="card">
                <img src="r3.png" alt="E-commerce">
                <h2>E-commerce</h2>
                <p>ST Courier services have opened up a new paradigm in the e-commerce industry. ST Courier can deliver a wide range of products based on the company's policies and specific trading regulations. E-commerce refers to companies and individuals that buy and sell goods and services over the internet. E-commerce</p>
                <a href="#" class="read-more">Read More</a>
            </div>
            <div class="card">
                <img src="r4.png" alt="Priority">
                <h2>Priority</h2>
                <p>We are pioneers in offering parcel and document services fast enough to reach your clients the next business day. This package is specially designed for time sensitive parcel and documents. STC Priority services come with money back guarantee if we fail to keep up our commitments. We deliver parcels up to 30kgs with a minimum</p>
                <a href="#" class="read-more">Read More</a>
            </div>
            <div class="card">
                <img src="r5.png" alt="Topay & COD">
                <h2>Topay & COD</h2>
                <p>Upcoming industry and trade is going to be fully through digitalized transactions only and to further substantiate and easify the process TOPAY and COD are the key modules. We are the most successful Logistics partners to trade on this platform due to our advanced financial monitoring systems enabling the seller and buyer to ...</p>
                <a href="#" class="read-more">Read More</a>
            </div>
            <div class="card">
                <img src="r6.png" alt="Reverse Logistics">
                <h2>Reverse Logistics</h2>
                <p>The delivered shipment can be collected from the consignee and return safely to origin (shipper).</p>
                <a href="#" class="read-more">Read More</a>
            </div>
        </div>
    </div>
    </div>
</asp:Content>
