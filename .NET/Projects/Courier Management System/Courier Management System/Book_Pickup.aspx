<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Book_Pickup.aspx.vb" Inherits="Courier_Management_System.Book_Pickup" EnableEventValidation="false" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>International Pickup</title>
    <style>
        body {
            font-family: 'Arial', sans-serif;
            background-color: #ffe6e6; /* Light red background */
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
        }

        .container {
            background-color: #ffffff;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 10px 20px rgba(0, 0, 0, 0.1);
            width: 100%;
            max-width: 850px;
        }

        h2 {
            text-align: center;
            margin-bottom: 30px;
            color: #d9534f; /* Light red color for heading */
        }

        label {
            font-size: 14px;
            margin-bottom: 5px;
            color: #d9534f; /* Light red for labels */
        }

        input[type="text"],
        select,
        .weight-slider input {
            width: 100%;
            padding: 12px;
            margin-bottom: 15px;
            border: 1px solid #d9534f; /* Light red border */
            border-radius: 5px;
            box-sizing: border-box;
        }

        .content-type {
            margin-bottom: 15px;
        }

        .content-type label {
            display: inline-block;
            margin-right: 15px;
            color: #d9534f;
        }

        .weight-info {
            font-size: 14px;
            color: #777;
            margin-bottom: 20px;
        }

        .weight-display {
            text-align: center;
            font-size: 22px;
            margin-bottom: 20px;
            font-weight: bold;
        }

        .amount-info {
            display: flex;
            justify-content: space-between;
            align-items: center;
            font-size: 16px;
            margin-bottom: 20px;
        }

        .amount-info span {
            font-weight: 500;
        }

        .duty-info {
            font-size: 12px;
            color: #777;
            margin-bottom: 20px;
            text-align: center;
        }

        .button-group {
            display: flex;
            justify-content: center;
        }

        button {
            background-color: #d9534f; /* Light red background */
            color: white;
            padding: 12px 30px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 16px;
            width: 100%;
            max-width: 300px;
        }

        button:hover {
            background-color: #c9302c; /* Slightly darker red on hover */
        }

        .two-columns {
            display: flex;
            gap: 20px;
            margin-bottom: 20px;
        }

        .two-columns div {
            flex: 1;
        }

        .two-columns input,
        .two-columns select {
            width: 100%;
        }

        @media (max-width: 600px) {
            .two-columns {
                flex-direction: column;
            }
        }

        /* Error Messages */
        .error-message {
            color: red;
            font-size: 14px;
        }
    </style>
</head>
<body>

<div class="container">
    <h2>International Pickup</h2>

    <form id="pickupForm" runat="server" onsubmit="return validateForm()">
        <label for="pincode">Pickup Pincode*:</label>
        <asp:TextBox ID="PincodeTextBox" runat="server" Placeholder="Enter Pickup Pincode" Required="true" />

        <label for="country">Delivery Country*:</label>
        <asp:DropDownList ID="CountryDropDown" runat="server" Required="true">
            <asp:ListItem Value="" Text="-- Select --" />
            <asp:ListItem Value="us" Text="United States" />
            <asp:ListItem Value="ca" Text="Canada" />
            <asp:ListItem Value="uk" Text="United Kingdom" />
            <asp:ListItem Value="au" Text="Australia" />
        </asp:DropDownList>

        <div class="content-type">
            <label>Type of Content*:</label><br>
            <asp:RadioButton ID="DocumentRadioButton" runat="server" GroupName="ContentType" Text="Document (Only Papers)" Checked="true" Value="document" />
            <asp:RadioButton ID="ParcelRadioButton" runat="server" GroupName="ContentType" Text="Non Document (Parcel)" Value="parcel" />
        </div>

        <div class="weight-info">
            <p><strong>Weight:</strong></p>
            <p>As per Airlines norms, the weight of the parcel (or) the dimension of the box whichever is higher will be applicable for costing/kg.</p>
        </div>

      <!-- Weight Range Slider -->
<label for="weight">Weight (grams):</label>
<input  id="WeightRange" min="1" max="2000" value="1" step="1" oninput="updateWeight()" runat="server" />
<span id="WeightDisplay" runat="server">1</span> grams

<!-- Amount Display -->
<div class="amount-info">
    <span>Amount</span>
    <span>₹<span id="AmountDisplay" runat="server">79</span></span>
</div>

        <div class="duty-info">
            Destination duties and taxes at actuals.
        </div>

        <label for="pickup-date">Pickup Date*:</label>
        <asp:TextBox ID="PickupDateTextBox" runat="server" Text="31-01-2025" ReadOnly="true" />

        <label for="pickup-time">Pickup Time*:</label>
        <asp:DropDownList ID="PickupTimeDropDown" runat="server" Required="true">
            <asp:ListItem Value="" Text="-- Select --" />
            <asp:ListItem Value="9am-12pm" Text="9am to 12pm" />
            <asp:ListItem Value="12pm-3pm" Text="12pm to 3pm" />
            <asp:ListItem Value="3pm-7pm" Text="3pm to 7pm" />
        </asp:DropDownList>

        <label for="email">Email ID*:</label>
        <asp:TextBox ID="EmailTextBox" runat="server" Placeholder="Enter your email" />

        <div class="two-columns">
            <div>
                <label for="full-name">Full Name*:</label>
                <asp:TextBox ID="FullNameTextBox" runat="server" Placeholder="Enter your full name" Required="true" />
            </div>
        </div>

        <div class="two-columns">
            <label for="phone">Phone / Mobile Number:</label>
            <asp:TextBox ID="PhoneTextBox" runat="server" Placeholder="Enter Your Mobile Number" />

            <label for="door-no">Door No/P.O. No/Street:</label>
            <asp:TextBox ID="DoorNoTextBox" runat="server" />
        </div>

        <div class="two-columns">
            <label for="area-city">Area/City:</label>
            <asp:DropDownList ID="AreaCityDropDown" runat="server">
                <asp:ListItem Value="" Text="-- Select City --" />
            </asp:DropDownList>

            <label for="state">State:</label>
            <asp:DropDownList ID="StateDropDown" runat="server" Required="true">
                <asp:ListItem Value="" Text="-- Select State --" />
                <asp:ListItem Value="TN" Text="Tamil Nadu" />
                <asp:ListItem Value="KA" Text="Karnataka" />
                <asp:ListItem Value="MH" Text="Maharashtra" />
            </asp:DropDownList>
        </div>

        <label for="aadhar">Aadhar Number:</label>
        <asp:TextBox ID="AadharTextBox" runat="server" />

        <div class="button-group">
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        </div>
    </form>
</div>

<script>
    document.getElementById('WeightRange').addEventListener('input', function() {
    let weight = this.value;
    let price = weight * 79; // Assuming 79 INR per gram
    document.getElementById('AmountDisplay').textContent = price;
});

const stateCityMap = {
    "TN": ["Chennai", "Coimbatore", "Madurai"],
    "KA": ["Bangalore", "Mysore", "Hubli"],
    "MH": ["Mumbai", "Pune", "Nagpur"]
};

document.getElementById('StateDropDown').addEventListener('change', function() {
    const cities = stateCityMap[this.value] || [];
    const citySelect = document.getElementById('AreaCityDropDown');
    citySelect.innerHTML = '<option value="">-- Select City --</option>';
    cities.forEach(city => {
        let option = document.createElement('option');
        option.value = city;
        option.textContent = city;
        citySelect.appendChild(option);
    });
});

function validateForm() {
    var weight = document.getElementById("WeightRange").value;
    if (weight < 1 || weight > 2000) {
        alert("Weight must be between 1 and 2000 grams.");
        return false;
    }

    // Validate required fields manually for ASP.NET controls
    var requiredFields = [
        'PincodeTextBox',
        'CountryDropDown',
        'PickupDateTextBox',
        'PickupTimeDropDown',
        'EmailTextBox',
        'FullNameTextBox',
        'StateDropDown'
    ];

    for (var id of requiredFields) {
        var field = document.getElementById(id);
        if (!field || !field.value.trim()) {
            alert("Please fill out all required fields.");
            return false;
        }
    }

    return true;
}
</script>

</body>
</html>
