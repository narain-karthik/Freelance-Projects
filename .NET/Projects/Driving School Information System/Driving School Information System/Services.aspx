<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Services.aspx.vb" Inherits="Driving_School_Information_System.Services" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <html>
    <head>
        <meta charset="UTF-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <title>Responsive Banner</title>
         <style>
            body {
                font-family: Arial, sans-serif;
                margin: 0;
                padding: 0;
                background-color: #f4f4f4;
            }
            
            h1 {
      text-align: center;
      margin-top: 2rem;
      color: #2c3e50;
    }

    /* Course Container Styles */
    .course-container {
      display: flex;
      justify-content: center;
      flex-wrap: wrap;
      gap: 2rem;
      margin: 3rem auto;
      max-width: 1200px;
    }

    .course {
      background-color: #ffffff;
      border-radius: 12px;
      box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
      padding: 2rem;
      width: 300px;
      cursor: pointer;
      transition: transform 0.3s, box-shadow 0.3s;
      text-align: center;
    }

    .course:hover {
      transform: translateY(-10px);
      box-shadow: 0 6px 15px rgba(0, 0, 0, 0.15);
    }

    .course .header {
      font-size: 1.5rem;
      font-weight: bold;
      color: #3498db;
      margin-bottom: 1rem;
    }

    .course .description {
      font-size: 1rem;
      color: #7f8c8d;
      margin: 1rem 0;
    }

    .course ul {
      list-style-type: none;
      padding: 0;
    }

    .course li {
      font-size: 1rem;
      color: #555;
      margin: 0.5rem 0;
    }

    /* Button Style */
    .course button {
      background-color: #3498db;
      color: #fff;
      border: none;
      padding: 0.8rem 1.2rem;
      border-radius: 8px;
      font-size: 1rem;
      cursor: pointer;
      transition: background-color 0.3s;
    }

    .course button:hover {
      background-color: #2980b9;
    }

    /* Image Styling */
    .course img {
      width: 150px;
      height: 150px;
      border-radius: 8px;
      margin-bottom: 1rem;
    }
             .style1
             {
                 width: 249px;
             }
             .style2
             {
                 width: 251px;
             }
             .style3
             {
                 width: 312px;
             }
             .style4
             {
                 width: 301px;
             }
             .style5
             {
                 width: 311px;
             }
             .style6
             {
                 width: 298px;
             }
             .style7
             {
                 width: 309px;
             }
             .style8
             {
                 width: 303px;
             }
  </style>
            </style>
    </head>
    <body>
        <div class="banner">
            <img src="Image/services_banner.jpg" alt="Banner"/>
        </div>
        <h1>Courses We Offer</h1>

  <div class="course-container">
    <!-- Course Example 1 -->
    <div class="course">
    <img src="Image/auto.png" alt="Automobile Engineering Diploma"/>
      <div class="header">Automobile Engineering Diploma</div>
      <div class="description">A one-year program focusing on AME aspects, licensing, and heavy equipment maintenance.</div>
      <ul>
        <li>Hands-on Training</li>
        <li>Job-Oriented Curriculum</li>
        <li>Opportunities in India & Overseas</li>
      </ul>
      <button>Learn More</button>
    </div>

    <!-- Course Example 2 -->
    <div class="course">
      <img src="Image/bike.jpg" alt="Two-Wheeler Training"/>
      <div class="header">Two-Wheeler & Four-Wheeler Training</div>
      <div class="description">Learn to drive motorcycles, scooters, and cars confidently.</div>
      <ul>
        <li>Theory & Practical Sessions</li>
        <li>Simulator-Assisted Classes</li>
        <li>Progress Tracking Report Card</li>
      </ul>
      <button>Learn More</button>
    </div>

    <!-- Course Example 3 -->
    <div class="course">
    <img src="Image/jcb.png" alt="Heavy-Equipment Training"/>
      <div class="header">Heavy Equipment Training</div>
      <div class="description">Comprehensive training for construction and industrial equipment operators.</div>
      <ul>
        <li>Forklift, Cranes, Excavators & More</li>
        <li>Safety & Terrain Practice</li>
        <li>Government-Approved Certification</li>
      </ul>
      <button>Learn More</button>
    </div>
  </div>
        <!-- Your table and other HTML elements go here, but ensure your structure is correct. -->
        <table style="width:100%; height: 431px;">
        <tr>
            <td class="style7" colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td class="style7" colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td class="style2">
                <asp:Image ID="Image2" runat="server" Height="200px" 
                    ImageUrl="~/Image/service/forklift.png" Width="200px" />
                <br />
                <br />
                FORKLIFT<br />
                <br />
            </td>
            <td class="style1">
                <asp:Image ID="Image3" runat="server" Height="200px" 
                    ImageUrl="~/Image/service/hitachi.png" Width="200px" />
                <br />
                <br />
                HITACHI<br />
                <br />
            </td>
            <td class="style3">
                <asp:Image ID="Image4" runat="server" Height="200px" 
                    ImageUrl="~/Image/service/mobile crane.png" Width="200px" />
                <br />
                <br />
                MOBILE CRANE<br />
                <br />
            </td>
            <td class="style6">
                <asp:Image ID="Image1" runat="server" Height="200px" 
                    ImageUrl="~/Image/service/crane.png" Width="200px" />
                <br />
                <br />
                CRANE<br />
                <br />
            </td>
            <td class="style8">&nbsp;</td>
            <td class="style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td class="style2">
                <asp:Image ID="Image7" runat="server" Height="200px" 
                    ImageUrl="~/Image/service/rough.png" Width="200px" />
                <br />
                <br />
                ROUGH TERRAIN CRANE</td>
            <td class="style1">
                <asp:Image ID="Image8" runat="server" Height="200px" 
                    ImageUrl="~/Image/service/tower.png" Width="200px" />
                <br />
                <br />
                TOWER CRANE</td>
            <td class="style3">
                <asp:Image ID="Image5" runat="server" Height="200px" 
                    ImageUrl="~/Image/service/rigging.png" Width="200px" />
                <br />
                <br />
                RIGGING</td>
            <td class="style6">
                <asp:Image ID="Image6" runat="server" Height="200px" 
                    ImageUrl="~/Image/service/road.png" Width="200px" />
                <br />
                <br />
                ROAD ROLLER</td>
            <td class="style8">&nbsp;</td>
            <td class="style5">&nbsp;</td>
        </tr>
        </table>

    <asp:Panel ID="Panel1" runat="server" Height="22px" Width="1164px">
        <br />
        <br />
    </asp:Panel>
    &nbsp;

    
  
   </body>
    </html>

</asp:Content>
