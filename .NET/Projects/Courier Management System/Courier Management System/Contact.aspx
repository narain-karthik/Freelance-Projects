<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Contact.aspx.vb" Inherits="Courier_Management_System.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* ... (CSS styles from previous response go here) ... */
         body {
            font-family: sans-serif;
            margin: 20px;
            background-color: #f0f0f0; /* Light gray background */
        }
       .container {
    max-width: 600px;
    margin: 0 auto;
    background-color: #ffcccc; /* Light red background */
    padding: 20px;
    border-radius: 8px;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1); /* Subtle shadow */
}

        h2 {
            color: #333; /* Darker heading color */
        }
        .contact-info {
            margin-top: 20px;
        }
        .info-item {
            display: flex;
            align-items: flex-start; /* Align items to the top */
            margin-bottom: 15px;
        }
        .info-icon {
            width: 30px;
            margin-right: 10px;
            color: #555; /* Slightly darker icon color */
        }
        .info-text {
            flex-grow: 1; /* Allow text to take up available space */
        }
        .dashed-line {
            border-top: 1px dashed #ccc;
            margin: 10px 0;
        }
        .business-hours {
            margin-top: 20px;
        }
        .day {
            display: flex;
            justify-content: space-between; /* Align day and hours */
            margin-bottom: 5px;
        }
        .closed {
            color: #999; /* Grayed out for closed days */
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Corporate Office</h2>
        <div class="dashed-line"></div>
        <div class="contact-info">
            <div class="info-item">
                <div class="info-icon">
                    <img src="k1.png" alt="Location Icon" width="20"/>
                </div>
                <div class="info-text">
                    No.199, Hariyan Street, C.Pallavaram, Coimbatore - 600 043.
                </div>
            </div>
            <div class="info-item">
                <div class="info-icon">
                    <img src="k2.png" alt="Phone Icon" width="20"/>
                </div>
                <div class="info-text">
                    Phone: 044-612 66 666
                </div>
            </div>
            <div class="info-item">
                <div class="info-icon">
                    <img src="k3.png" alt="Email Icon" width="20"/>
                </div>
                <div class="info-text">
                    Email: helpdesk@courier.com
                </div>
            </div>
        </div>
        <div class="business-hours">
            <h3>Business Hours</h3>
            <div class="day">
                <span>Monday - Friday:</span> <span>10:00 AM to 6:30 PM</span>
            </div>
            <div class="day">
                <span>Saturday:</span> <span>10:00 AM to 4:30 PM</span>
            </div>
            <div class="day">
                <span>Sunday:</span> <span class="closed">Closed</span>
            </div>
        </div>
    </div>
</asp:Content>