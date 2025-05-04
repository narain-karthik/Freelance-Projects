<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="About.aspx.vb" Inherits="Dental_clinic_appointment.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
            <h2> About Us</h2>
        </div>

        <div class="about-us">
            <div class="image-column">
                
                <asp:Image ID="CateringImage2" runat="server" ImageUrl="medical.png" alt="Catering Image 2" />
            </div>

            <div class="text-column">
                <div class="since">Since 1998</div>
                <h2>Our Story</h2>
                <p>Hello,

I would like to share my story with you; about why, out of all the professions available, I chose to be a dentist and why I feel it has been one of the best decisions of my life.

I spent my teenage years full of angst and low self esteem fixating on my teeth and despising their shape, colour, size and the spaces between them. Combined with being overweight and having virtually no social life, I spent most of my days feeling embarrassed about just being me.

One day my 71 year old aunt visited our family and my life was about to change forever. She looked younger, healthier and happier than ever before and when I looked closer, I noticed that her smile was full of beautiful perfect white teeth. When I asked about her new energetic self and gorgeous smile, she started singing the praises about a dentist she had been visiting who had replaced her old broken, decayed, diseased and painful teeth with stunning new ones permanently fixed on dental implants that allowed her to smile and eat as if she was in her twenties.

I couldn’t believe it and had never seen such a thing before. The very next day I made an appointment with the same dentist and counted the days and hours prior to visiting him.

 </p>

                <asp:HyperLink ID="BookNowLink" runat="server" NavigateUrl="login.aspx" CssClass="book-now">Book Now</asp:HyperLink> <%-- ASP.NET Link --%>

            </div>
        </div>
    </div>
</asp:Content>