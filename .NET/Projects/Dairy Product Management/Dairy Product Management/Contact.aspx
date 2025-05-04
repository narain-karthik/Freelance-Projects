<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master_Page.Master" CodeBehind="Contact.aspx.vb" Inherits="Dairy_Product_Management.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Begin Contact Page Content -->
    <div class="container">
        <div class="header">
            <img src="image/contact.jpg" alt="Contact Us Image" class="contact-image"/>
        </div>

        <div class="contact-info">
            <div class="contact-details">
                <h2>Contact Information</h2>
                <p><strong>Generali Office:</strong></p>
                <p>505 Sangeeth Towers, Sardar Patel Road, Near Military Gate,</p>
                <p>Tamil Nadu, Coimbatore 500003</p>

                <p><p><strong>Our Farm:</strong></p></p>
                <p>Survey No. 81 & 82, Thummala Palle Village, Shamshabad,</p>
                <p>Tamil Nadu, Coimbatore 501218</p>

                <p><strong>Registered Address:</strong></p>
                <p>H.No. 5-5-11/A, Postal Colony, R.S. Puram,</p>
                <p>Tamil Nadu, Coimbatore 500039</p>

                <p><strong>Email:</strong>&nbsp; <a href="mailto:connect@saintsol.in">connect@saintsol.in</a></p>
                <p><strong>Phone:</strong>&nbsp; <a href="tel:+91 7799884411">+91 7799884411</a></p>
            </div>

            <div class="form-details">
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
</asp:Content>
