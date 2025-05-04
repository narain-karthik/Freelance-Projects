<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.vb" Inherits="Graments.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner">
        <asp:Image ID="BannerImage" runat="server" ImageUrl="banner.jpg" AlternateText="Banner Image" />  <%-- Or use a literal control for more flexibility --%>
        <%-- OR --%>
        <%--<asp:Literal ID="BannerLiteral" runat="server"></asp:Literal>--%>
        <div class="banner-text">
            <h1>Welcome to Graments</h1>  <%-- Example banner text --%>
            <p>Your tagline or short description here.</p> <%-- Example tagline --%>
            <asp:Button ID="ShopNowButton" runat="server" Text="View Product" CssClass="shop-now-button" /> <%-- Example button --%>
        </div>
    </div>

    <style type="text/css">
        .banner {
            position: relative; /* Needed for positioning the text */
            width: 100%;
            overflow: hidden; /* Prevents image overflow */
        }

        .banner img {
            width: 100%;
            display: block; /* Prevents a small gap below the image */
            height: auto; /* Maintains aspect ratio */
        }

        .banner-text {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%); /* Centers the text */
            color: white; /* Example text color */
            text-align: center; /* Example text alignment */
            width: 80%; /* Adjust width as needed */
        }

        .banner-text h1 {
            font-size: 3em; /* Example heading size */
            margin-bottom: 0.5em; /* Example margin */
        }

        .banner-text p {
           font-size: 1.2em; /* Example paragraph size */
           margin-bottom: 1em;
        }

        .shop-now-button {
            background-color: #007bff; /* Example button color */
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

        /* Responsive adjustments (Example) */
        @media (max-width: 768px) {
            .banner-text h1 {
                font-size: 2em;
            }
            .banner-text p {
                font-size: 1em;
            }
        }
    </style>

    <%-- Rest of your content --%>
</asp:Content>