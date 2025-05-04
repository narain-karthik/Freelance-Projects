<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.vb" Inherits="Logistic_Management_System.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .home-content {
            padding: 20px;
            text-align: center;
        }
        .home-content h2 {
            color: #2c3e50;
            margin-bottom: 15px;
        }
        .home-content p {
            font-size: 16px;
            line-height: 1.6;
            color: #555;
        }
        .home-image {
            margin: 20px auto;
            max-width: 600px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="home-content">
        <h2>Welcome to Your Logistic Management Solution</h2>
        <p>
            Simplify and optimize your logistics operations with our all-in-one management system. 
            From tracking orders to managing inventory, warehouses, labor, and transportation, 
            we provide the tools you need to ensure efficiency and accuracy every step of the way.
        </p>
        <p>
            Get started by selecting a module from the navigation menu above and take control 
            of your supply chain today!
        </p>
        <div class="home-image">
            <asp:Image ID="HomeImage" runat="server" ImageUrl="Image.jpg" 
                AlternateText="Logistics Operations Overview" Width="100%" />
            <p><em>Visualize your logistics with real-time insights.</em></p>
        </div>
    </div>
</asp:Content>
