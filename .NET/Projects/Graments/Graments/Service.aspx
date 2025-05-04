<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Service.aspx.vb" Inherits="Graments.Service" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Premium services</h2>

        <div class="services">
            <div class="service">
                <img src="Image/1.jpg" alt="Fabrics">
                <div class="service-content">
                    <h3>Fabrics</h3>
                    <p>Woven Fabrics<br /> Yarn Count<br />• We offer counts in 10s, 20s, 30s, 40s, 50s, 60s, 80s and 2/100s, 40D, 40SF.</p>
                </div>
            </div>
            <div class="service">
                <img src="Image/2.jpg" alt="Design Studio">
                <div class="service-content">
                    <h3>Design Studio</h3>
                    <p>Integrated computerized sample section with the daily output 500 pieces and some customer approach self-fit & PP sample approval. Our sample section has ability to hand any type of garments.</p>
                </div>
            </div>
            <div class="service">
                <img src="Image/3.jpg" alt="Cutting & Stitching">
                <div class="service-content">
                    <h3>Cutting & Stitching</h3>
                    <p> The key to producing fine garments lies in cutting. We have Marker Mechanism with CAD cutting systems to deliver accuracy in cuts. Our infrastructure facilitates cuts in both standards and customized size. Automated fabric spreading machines for open width and woven fabrics are also present. Our dexterous craftsmen ensure exactness in size standards as well as minimization of waste.</p>
                </div>
            </div>
            <div class="service">
                <img src="Image/4.jpg" alt="Printing">
                <div class="service-content">
                    <h3>Printing</h3>
                    <p>Printing is a key area for leaving a lasting impression. We employ the latest technology to perfect our printing. Rotary printing systems have been installed to offer our customers a range of print options. The printing systems can print around one lakh metres/day. With customized print options available, we are able to offer value additions to our customers.</p>
                </div>
            </div>
            <div class="service">
                <img src="Image/5.jpg" alt="Embroidery">
                <div class="service-content">
                    <h3>Embroidery</h3>
                    <p> Intricate embroidery works are a value addition we provide our customers with. Our Embroidery division is equipped with 24 imported machines offering high precision and pace. The machines make it possible to design embellishments, motifs and logo designs on the garments. With the best kind of equipments in place, we are capable of delivering 11.1 million complex stiches per day</p>
                </div>
            </div>
            <div class="service">
                <img src="Image/6.jpg" alt="Quality Checking">
                <div class="service-content">
                    <h3>Quality Checking</h3>
                    <p>We have adopted Total Quality Management (TQM) initiative in our processes, functioning and management. Every measure we take is a symbol of our commitment to meet international quality standards.</p>
                </div>
            </div>
            <div class="service">
                <img src="Image/7.jpg" alt="Finishing">
                <div class="service-content">
                    <h3>Finishing</h3>
                    <p>Washing <br />Ironing & Packing</p>
                </div>
            </div>
        </div>
    </div>

    <style>
        body {
            font-family: sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
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
        }

        .services {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            grid-gap: 20px;
        }

        .service {
            border: 1px solid #ddd;
            padding: 20px;
            text-align: center;
            overflow: hidden;
            display: flex;
            flex-direction: column;
            min-height: 400px; /* Ensures all service boxes are the same height */
        }

        .service img {
            max-width: 100%;
            height: 250px; /* Fixed height for images */
            object-fit: cover; /* Ensures images cover the entire area */
            margin-bottom: 10px;
        }

        .service-content {
            flex-grow: 1; /* Allows content to take up remaining space */
            text-align: left;
        }

        .service h3 {
            margin-bottom: 10px;
        }

        /* Responsive adjustments */
        @media (max-width: 768px) {
            .services {
                grid-template-columns: 1fr;
            }
            .service {
                min-height: auto; /* Remove fixed height on smaller screens */
            }
             .service img {
                height: 200px; /* Slightly smaller image on mobile */
            }
        }
    </style>
</asp:Content>