<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Contact.aspx.vb" Inherits="Graments.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!-- Begin Contact Page Content -->
    <div class="container">
        <div class="header">
            <img src="contact.jpg" alt="Contact Us Image" class="contact-image"/>
        </div>

        <div class="contact-info">
            <div class="contact-details">
                <h2>Contact Information</h2>
                <p><strong>Generali Office:</strong></p>
                <p>505 Sangeeth Towers, Sardar Patel Road, Near Military Gate,</p>
                <p>Tamil Nadu, Coimbatore 500003</p>

                <p><p><strong>Our Graments:</strong></p></p>
                <p>Survey No. 81 & 82, Thummala Palle Village, Shamshabad,</p>
                <p>Tamil Nadu, Coimbatore 501218</p>

                <p><strong>Registered Address:</strong></p>
                <p>H.No. 5-5-11/A, Postal Colony, R.S. Puram,</p>
                <p>Tamil Nadu, Coimbatore 500039</p>

                <p><strong>Email:</strong>&nbsp; <a href="mailto:connect@saintsol.in">connect@saintsol.in</a></p>
                <p><strong>Phone:</strong>&nbsp; <a href="tel:+91 7799884411">+91 7799884411</a></p>
            </div>

            <div class="form-details">
            <h1>Enquriy Us </h1>
                <h2>Send us a message</h2>
                <form action="#" method="post">
                    <div class="form-group">
                        <label for="name">Your Name:</label>&nbsp;
                        <asp:TextBox ID="NameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="phone">Your Phone Number:</label>&nbsp;
                        <asp:TextBox ID="PhoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="email">Your Email:</label>&nbsp;
                        <asp:TextBox ID="EmailTextBox" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="message">Message:</label>&nbsp;
                        <asp:TextBox ID="MessageTextBox" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                        <br />
                       <br /> <asp:Button ID="SubmitButton" runat="server" Text="Submit" CssClass="btn-submit" />
                    </div>
                </form>
            </div>
        </div>
    </div>
    <!-- End Contact Page Content -->
    <style>
    /* General styling for the contact page */
.container {
    max-width: 1200px;
    margin: 0 auto;
    padding: 20px;
}

.header {
    text-align: center;
    margin-bottom: 30px;
}

.contact-image {
    max-width: 100%;
    height: auto;
    border-radius: 8px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}

.contact-info {
    display: flex;
    justify-content: space-between;
    gap: 40px;
}

.contact-details,
.form-details {
    width: 48%;
}

.contact-details h2,
.form-details h2 {
    color: #333;
    margin-bottom: 20px;
}

.contact-details p {
    font-size: 16px;
    color: #555;
    margin: 10px 0;
}

.contact-details a {
    color: #007bff;
    text-decoration: none;
}

.contact-details a:hover {
    text-decoration: underline;
}

/* Form styling */
.form-group {
    margin-bottom: 15px;
}

.form-group label {
    font-size: 16px;
    color: #333;
    display: block;
    margin-bottom: 5px;
}

.form-control {
    width: 100%;
    padding: 10px;
    font-size: 14px;
    border: 1px solid #ccc;
    border-radius: 5px;
    box-sizing: border-box;
}

.form-control:focus {
    border-color: #007bff;
    outline: none;
    box-shadow: 0 0 5px rgba(0, 123, 255, 0.5);
}

.btn-submit {
    background-color: #007bff;
    color: white;
    padding: 10px 20px;
    border: none;
    border-radius: 5px;
    cursor: pointer;
}

.btn-submit:hover {
    background-color: #0056b3;
}

@media screen and (max-width: 768px) {
    .contact-info {
        flex-direction: column;
    }
    
    .contact-details, .form-details {
        width: 100%;
    }
}
</style>
</asp:Content>
