<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.vb" Inherits="Dental_clinic_appointment.Home" %>

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
        <h2>Premium services</h2>

        <div class="services">
            <div class="service">
                <img src="about.jpg" alt="Wedding Event">
                <div class="service-content">
                    <h3>Are You Looking for The Best Dental Clinic in Delhi or The Best Dental Clinic in India?</h3>
                    <p>How do you filter through all the results that come up? There are many fine professional dental practices that would consider themselves The Best Dental Clinic in Delhi and The Best Dental Clinic in India. However, we also know from all of the remedial dental work we undertake every week on patients who have had far from satisfactory experiences. We also know from our international patients that this phenomenon is not just limited to Dental clinics in India.</p>
                </div>
            </div>
            <div class="service">
                <img src="about1.jpg" alt="Corporate Event">
                <div class="service-content">
                    <h3>Pediatric Dentist</h3>
                    <p>Baby teeth play an important role in your child’s overall health, development, and well-being. They are vitally important for the future life of a child.

Just because your child’s baby teeth eventually fall out, and are replaced by permanent teeth doesn’t mean they are not important.</p>
                </div>
            </div>
            <div class="service">
                <img src="about2.jpg" alt="Birthday Party">
                <div class="service-content">
                    <h3>Teeth Whitening Clinic and Dentist</h3>
                    <p>Teeth discolouration is a common problem, faced by people all over the world. Black tea, black coffee, smoking, red wine, the traditional foods which involve the use of spices like turmeric, are the most common cause of teeth discolouration. Apart from this, sodas and aerated cold drinks can harm the enamel and make it more prone to discolouration. Teeth whitening products like toothpastes or home remedies can also do more harm than good.</p>
                </div>
            </div>
        </div>

        <div class="view-all">
            <a href="#">View All Services</a>
        </div>
    </div>
</asp:Content>