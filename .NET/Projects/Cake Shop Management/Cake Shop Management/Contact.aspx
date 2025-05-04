<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Contact.aspx.vb" Inherits="Cake_Shop_Management.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            font-family: 'Arial', sans-serif;
            margin: 0;
            padding: 0;
            background-color: #fff0b3;
        }
        .container {
            max-width: 960px;
            margin: 20px auto;
            padding: 30px;
            background-color: #fff;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
        }
        .header {
            text-align: center;
            margin-bottom: 30px;
        }
        .header h1 {
            font-size: 2.5rem;
            color: #333;
            margin-bottom: 10px;
        }
        .header p {
            color: #666;
            font-size: 1rem;
            margin-bottom: 20px;
        }
        .form-container {
            display: flex;
            flex-wrap: wrap;
            gap: 30px;
            justify-content: space-between;
        }
        .form-group {
            width: calc(50% - 15px);
            margin-bottom: 20px;
        }
        label {
            display: block;
            margin-bottom: 8px;
            color: #333;
            font-weight: 600;
        }
        .form-control {
            width: 100%;
            padding: 12px;
            border: 1px solid #ddd;
            border-radius: 5px;
            box-sizing: border-box;
            font-size: 1rem;
            transition: border-color 0.3s ease-in-out;
        }
        .form-control:focus {
            border-color: #4CAF50;
            outline: none;
        }
        textarea {
            height: 120px;
            resize: vertical;
        }
        .file-upload {
            margin-top: 10px;
        }
        .submit-btn {
            text-align: center;
            margin-top: 20px;
        }
        .btn-submit {
            padding: 12px 25px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 1rem;
            transition: background-color 0.3s ease-in-out;
        }
        .btn-submit:hover {
            background-color: #45a049;
        }
        .contact-details {
            width: calc(30% - 15px);
            padding: 25px;
            background-color: #f7f7f7;
            border: 1px solid #ddd;
            border-radius: 8px;
        }
        .contact-details h3 {
            margin-top: 0;
            font-size: 1.6rem;
            color: #333;
        }
        .contact-details p {
            font-size: 1rem;
            margin-bottom: 10px;
            color: #444;
        }
        .contact-details img {
            max-width: 100%;
            height: auto;
            display: block;
            margin-bottom: 20px;
            border-radius: 8px;
        }

        /* Responsive adjustments */
        @media (max-width: 768px) {
            .form-group {
                width: 100%;
            }
            .contact-details {
                width: 100%;
                margin-top: 20px;
            }
            .header h1 {
                font-size: 2rem;
            }
            .header p {
                font-size: 0.9rem;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="header">
            <h1>Contact Us</h1>
            <p>We would love to hear from you. Share your thoughts and queries with us!</p>
        </div>

        <div class="form-container">
            <div class="form-group">
                <label for="name">Name*</label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" Required="True" Placeholder="Enter your full name" aria-label="Full Name"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="contact">Contact no.*</label>
                <asp:TextBox ID="txtContact" runat="server" CssClass="form-control" Required="True" MaxLength="10" Pattern="[0-9]{10}" aria-label="Contact Number"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="email">Email ID*</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Type="email" Required="True" aria-label="Email Address"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="city">City*</label>
                <asp:TextBox ID="txtCity" runat="server" CssClass="form-control" Required="True" aria-label="City"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="subject">Subject*</label>
                <asp:DropDownList ID="ddlSubject" runat="server" CssClass="form-control" Required="True">
                    <asp:ListItem Text="Choose your subject" Value="" />
                    <asp:ListItem Text="Support" Value="support" />
                    <asp:ListItem Text="Feedback" Value="feedback" />
                    <asp:ListItem Text="General Inquiry" Value="inquiry" />
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="message">Message*</label>
                <asp:TextBox ID="txtMessage" runat="server" CssClass="form-control" TextMode="MultiLine" Required="True" aria-label="Your Message"></asp:TextBox>
            </div>
            <div class="form-group file-upload">
                <label for="file">Attach Files</label>
                <asp:FileUpload ID="fileUpload" runat="server" CssClass="form-control" Accept=".jpeg,.png,.pdf" aria-label="Attach File" />
                <p>Note: We accept file sizes up to 1MB and in JPEG, PNG, or PDF format.</p>
            </div>

            <div class="submit-btn">
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" CssClass="btn-submit" OnClick="SubmitButton_Click" />
            </div>
        </div>

     <center>   <div class="contact-details">
            <img src="logo/letter.png" alt="Contact Image">
            <h3>Cake Factory Private Limited</h3>
            <p><strong>Registered Address:</strong><br>
                32/33 A, Deonar Village Road, Opp. Metal Box Company, Govandi East, Coimbatore-400088, Tamil Nadu, India</p>
            <p><strong>Grievance & Nodal Officer:</strong><br>
                Ms. Simantini Budukh, General Counsel & Company Secretary</p>
            <p><strong>Contact Details:</strong><br>
                +91 8182-881881<br>
                <a href="mailto:contact@Cake.in">contact@Cake.in</a></p>
        </div></center>
    </div>
</asp:Content>
