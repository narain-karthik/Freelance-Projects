<%@ Page Title="About Us - Graments" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="About.aspx.vb" Inherits="Graments.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="container">
        <div class="header">
            <h1>Progressing through Performance</h1>
        </div>

        <div class="section">
            <div class="section-title">Mission  
     <img src="logo/target.png" />     </div>
            <div class="content">
                To become an embodiment of quality garments produced consistently according to customer needs using innovative technology within the stipulated period of time and at affordable costs.
            </div>
        </div>

        <div class="section">
            <div class="section-title">Vision   
         <img src="logo/vision.png" />     </div>
            <div class="content">
                We strive to be a global leader in fashion-knit and fashion outerwear by empowering innovation and design to provide total customer satisfaction.<br><br>
                We also aspire to be a caring and well-managed organization for our business partners, customers, and employees, and a responsible corporate citizen to our society, always considering the human factor in every decision.
            </div>
        </div>

        <div class="section">
            <div class="section-title">Values  
             <img src="logo/customer.png" /> </div>
            <div class="content">
                Committed to the best practices, our Quality Policy aims at enhancing customer satisfaction by supplying products as per internationally accepted norms, adhering to effective quality management systems and ensuring continual improvement and innovation in our products and services. We stand committed to the best practices of work and proactive customer understanding for long-term success and mutually profitable relationships with our customers.
            </div>
        </div>

        <div class="section">
            <div class="section-title">All for that perfect finish</div>
            <div class="content perfect-finish-section">
                <div class="perfect-finish-column">
                   
                 <img src="logo/cutting.png" />
                    <h3>FABRICS</h3>
                    <p>Each project requires a different fabric type. From soft and stretchy jersey material, and natural types of silk, to organic types of cotton fabric and types of canvas fabric, the right textile can make all the difference and Textile we are here to help you choose the right Fabric for your perfect Garment that offer performance and comfort. Print your art and patterns on over wide range of fabrics collection.</p>
                    <a href="#">Read more</a>  </div>
                <div class="perfect-finish-column">
                   
                     <img src="logo.png" />
                    <h3>GARMENTING</h3>
                    <p>Our professional planning & production team has an advanced manufacturing knowledge and extensive experience especially in fashion products. All production stops from cutting to sewing packaging and controlling, are handled by our well-qualified employees. We use the latest technology throughout our production facilities to produce, control and deliver high quality products to our customers. Highest quality standards and timely delivery is our strength.our satisfied customers prove us right. Share the ideas of dream product with us We take care of bringing it to life.</p>
                    <a href="#">Read more</a>  </div>
                <div class="perfect-finish-column">
                    
                         <img src="logo/logistics.png" />
                    <h3>LOGISTICS</h3>
                    <p>Coimbatore, the testile hub of the south, has an established road and rail network in place. We are well-connected with all the major shipping ports and airports worldwide. The strategic location. Combined with cost-effective facilities, has augured well for our business across national and international frontiers.</p>
                    <a href="#">Read more</a>  </div>
            </div>
        </div>
    </div>
    <style>
        body {
            font-family: sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
            color: #333;
        }

        .container {
            width: 80%;
            margin: 20px auto;
            background-color: #fff;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        .header {
            text-align: center;
            margin-bottom: 20px;
        }

        .section {
            margin-bottom: 20px;
        }

        .section-title {
            font-size: 1.2em;
            font-weight: bold;
            margin-bottom: 10px;
            display: flex; /* Use flexbox for icon alignment */
            align-items: center; /* Vertically align icon and text */
        }

        .section-title img {
            max-width: 20px;
            height: auto;
            margin-left: 5px;
        }


        .content {
            text-align: justify;
        }

        .highlight {
            color: #d9534f; /* Example highlight color */
        }

        /* Responsive adjustments */
        @media screen and (max-width: 768px) {
            .container {
                width: 95%;
            }
        }

        /* Styles for the "All for that perfect finish" section */
        .perfect-finish-section {
            display: flex;
            justify-content: space-around; /* Distribute columns evenly */
            flex-wrap: wrap; /* Allow wrapping on smaller screens */
        }

        .perfect-finish-column {
            width: 30%; /* Adjust as needed */
            margin-bottom: 20px;
            padding: 15px;
            border: 1px solid #ddd; /* Optional border */
            box-sizing: border-box; /* Include padding in width calculation */
            text-align: center; /* Center content within columns */
        }

        .perfect-finish-column img {
            max-width: 100%; /* Make sure images don't overflow */
            height: auto;
            margin-bottom: 10px;
        }

        .perfect-finish-column h3 {
            margin-bottom: 10px;
        }

        .perfect-finish-column p {
            text-align: justify;
        }

        .perfect-finish-column a {
            display: inline-block;
            padding: 8px 16px;
            background-color: #007bff; /* Example button color */
            color: white;
            text-decoration: none;
            border-radius: 4px;
        }
    </style>
</asp:Content>