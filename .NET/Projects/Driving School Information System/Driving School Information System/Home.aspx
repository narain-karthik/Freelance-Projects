<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.vb" Inherits="Driving_School_Information_System.WebForm1" %>
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

            .banner {
                width: 100%;
                height: 400px;
                background-color: #fff;
                overflow: hidden;
            }

            .banner img {
                width: 100%;
                height: 100%;
                object-fit: cover;
                display: block;
            }

            h1 {
                text-align: center;
                margin-top: 2rem;
                color: #2c3e50;
            }

            /* Pricing Plan Styles */
            .pricing-container {
                display: flex;
                justify-content: center;
                flex-wrap: wrap;
                gap: 2rem;
                margin: 3rem auto;
                max-width: 1200px;
            }

            .plan {
                background-color: #ffffff;
                border-radius: 12px;
                box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
                padding: 2rem;
                width: 300px;
                cursor: pointer;
                transition: transform 0.3s, box-shadow 0.3s;
                text-align: center;
            }

            .plan:hover {
                transform: translateY(-10px);
                box-shadow: 0 6px 15px rgba(0, 0, 0, 0.15);
            }

            .plan .header {
                font-size: 1.5rem;
                font-weight: bold;
                color: #3498db;
                margin-bottom: 1rem;
            }

            .plan .price {
                font-size: 1.3rem;
                font-weight: bold;
                color: #2ecc71;
                margin-bottom: 1rem;
            }

            .plan li {
                font-size: 1rem;
                color: #7f8c8d;
                margin: 0.5rem 0;
            }

            /* Modal Styles */
            .modal {
                display: none;
                position: fixed;
                z-index: 10;
                left: 0;
                top: 0;
                width: 100%;
                height: 100%;
                background-color: rgba(0, 0, 0, 0.6);
                overflow: hidden;
            }

            .modal-content {
                background-color: #ffffff;
                border-radius: 12px;
                box-shadow: 0 4px 15px rgba(0, 0, 0, 0.2);
                width: 90%;
                max-width: 500px;
                margin: 5% auto;
                padding: 2rem;
            }

            .modal-header {
                font-size: 1.5rem;
                font-weight: bold;
                color: #333;
                margin-bottom: 1rem;
                text-align: center;
            }

            .modal-body label {
                font-weight: bold;
                margin-top: 1rem;
                display: block;
                color: #555;
            }

            .modal-body input {
                width: 100%;
                padding: 0.8rem;
                margin: 0.5rem 0;
                border-radius: 8px;
                border: 1px solid #ddd;
                font-size: 1rem;
                box-shadow: inset 0 1px 3px rgba(0, 0, 0, 0.1);
            }

            .modal-body input:focus {
                outline: none;
                border-color: #3498db;
                box-shadow: 0 0 5px rgba(52, 152, 219, 0.5);
            }

            .modal-footer {
                display: flex;
                justify-content: flex-end;
                margin-top: 1rem;
            }

            .modal-footer button {
                background-color: #3498db;
                color: white;
                border: none;
                padding: 0.8rem 1.5rem;
                border-radius: 8px;
                font-size: 1rem;
                cursor: pointer;
                transition: background-color 0.3s;
            }

            .modal-footer button:hover {
                background-color: #2980b9;
            }

            #closeBtn {
                position: absolute;
                top: 10px;
                right: 20px;
                font-size: 1.5rem;
                cursor: pointer;
                color: #555;
            }
            .style1
            {
                text-align: center;
            }
            .style2
            {
                text-align: center;
                font-size: x-large;
            }
            .style3
            {
                width: 18px;
            }
            .style4
            {
                width: 22px;
            }
            .style5
            {
                width: 24px;
            }
            .style6
            {
                width: 26px;
            }
            .style7
            {
                width: 80px;
            }
        </style>
    </head>
    <body>
        <div class="banner">
            <img src="Image/banner.jpg" alt="Banner"/>
        </div>

        <!-- Your table and other HTML elements go here, but ensure your structure is correct. -->
        <table style="width:100%; height: 431px;">
        <tr>
            <td class="style7">&nbsp;</td>
            <td class="style1" colspan="6">
                WHY CHOOSE US?<br />
            </td>
        </tr>
        <tr>
            <td class="style7">&nbsp;</td>
            <td class="style1" colspan="6">&nbsp;</td>
        </tr>
        <tr>
            <td class="style7">&nbsp;</td>
            <td class="style6">
                <asp:Image ID="Image1" runat="server" Height="117px" ImageUrl="~/Image/car.png" Width="117px" />
            </td>
            <td class="style4">
                <asp:Image ID="Image2" runat="server" Height="117px" ImageUrl="~/Image/time.png" Width="117px" />
            </td>
            <td class="style3">
                <asp:Image ID="Image4" runat="server" Height="117px" ImageUrl="~/Image/branch.png" Width="117px" />
            </td>
            <td class="style3">
                <asp:Image ID="Image5" runat="server" Height="117px" ImageUrl="~/Image/service.png" Width="117px" />
            </td>
            <td class="style3">
                <asp:Image ID="Image6" runat="server" Height="117px" ImageUrl="~/Image/traffic.png" Width="117px" />
            </td>
            <td class="style5">
                <asp:Image ID="Image3" runat="server" Height="117px" ImageUrl="~/Image/wheel.png" Width="117px" />
            </td>
        </tr>
        <tr>
            <td class="style7">&nbsp;</td>
            <td class="style6">Multi Branded New<br />Generations Cars</td>
            <td class="style4">Flexible Timing</td>
            <td class="style3">15+Branches &amp; coming</td>
            <td class="style3">Day to Day maintenance</td>
            <td class="style3">Traffic education<br />&amp; theory class</td>
            <td class="style5">Stimulator training<br />2 wheelers &amp; cars</td>
        </tr>
        <tr>
            <td class="style7">&nbsp;</td>
            <td class="style6">&nbsp;</td>
            <td class="style4">&nbsp;</td>
            <td class="style3">&nbsp;</td>
            <td class="style3">&nbsp;</td>
            <td class="style3">&nbsp;</td>
            <td class="style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="style2" colspan="7"><strong>Select Your Plan</strong></td>
        </tr>
        <tr>
            <td class="style1" colspan="7">&nbsp;</td>
        </tr>
    </table>

    <asp:Panel ID="Panel1" runat="server" Height="22px" Width="1164px">
        <br />
        <br />
    </asp:Panel>
    &nbsp;

    <div class="pricing-container">
        <div class="plan" onclick="openModal('Car Plan - ₹4500')">

            <div class="header">CAR</div>
            <div class="price">₹4500 (incl. GOVT. FEES ₹1255)</div>
            <ul>
                <li>Learners & License</li>
                <li>Training - Free</li>
                <li>Theory Class - Free</li>
                <li>Per-Day Driving Lesson - ₹300</li>
            </ul>
        </div>
       <div class="plan" onclick="openModal('Car+MotorCycle - ₹5000')">

            <div class="header">CAR + MOTORCYCLE</div>
            <div class="price">₹5000 (incl. GOVT. FEES ₹1455)</div>
            <ul>
                <li>Learners & License</li>
                <li>Training - Free</li>
                <li>Theory Class - Free</li>
                <li>Per-Day Driving Lesson - ₹300+200</li>
            </ul>
        </div>
        <div class="plan" onclick="openModal('MotorCycle - ₹3000')">

            <div class="header">MOTORCYCLE</div>
            <div class="price">₹3000 (incl. GOVT. FEES ₹1005)</div>
            <ul>
                <li>Learners & License</li>
                <li>Training - Free</li>
                <li>Theory Class - Free</li>
                <li>Per-½hr Driving Lesson - ₹200</li>
            </ul>
        </div>
         <div class="plan" onclick="openModal('Heavy Vechile - ₹10,000')">

            <div class="header">HEAVY VEHICLE</div>
            <div class="price">₹10,000 (incl. GOVT. FEES ₹4005)</div>
            <ul>
                <li>Learners & License</li>
                <li>Training - Free</li>
                <li>Theory Class - Free</li>
                <li>Per-½hr Driving Lesson - ₹800</li>
            </ul>
        </div>
    </div>
    <!-- Modal -->
  <div id="myModal" class="modal">
    <div class="modal-content">
      <span id="closeBtn">&times;</span>
      <div class="modal-header">Enquiry Form</div>
      <div class="modal-body">
        <label for="name">Name:</label>
        <input type="text" id="name" placeholder="Enter your name" required>

        <label for="email">Email:</label>
        <input type="email" id="email" placeholder="Enter your email" required>

        <label for="phone">Phone Number:</label>
        <input type="tel" id="phone" placeholder="Enter your phone number" required>

        <label for="dob">Date of Birth:</label>
        <input type="date" id="dob" required>

        <label for="package">Selected Package:</label>
        <input type="text" id="package" readonly>
      </div>
      <div class="modal-footer">
        <button onclick="submitForm()">Submit</button>
      </div>
    </div>
  </div>

  <script>
    function openModal(planName) {
      document.getElementById('myModal').style.display = 'block';
      document.getElementById('package').value = planName;
    }

    document.getElementById('closeBtn').onclick = function () {
      document.getElementById('myModal').style.display = 'none';
    };

    window.onclick = function (event) {
      if (event.target == document.getElementById('myModal')) {
        document.getElementById('myModal').style.display = 'none';
      }
    };

    function validateAge(dob) {
      const birthDate = new Date(dob);
      const today = new Date();
      const age = today.getFullYear() - birthDate.getFullYear();
      const m = today.getMonth() - birthDate.getMonth();
      return m < 0 || (m === 0 && today.getDate() < birthDate.getDate()) ? age - 1 >= 18 : age >= 18;
    }

    function submitForm() {
      const dob = document.getElementById('dob').value;
      if (!validateAge(dob)) {
        alert('You must be at least 18 years old to apply.');
        return;
      }
      alert('Form submitted successfully!');
      document.getElementById('myModal').style.display = 'none';
    }
  </script>
    
</body>
</html>
</asp:Content>

