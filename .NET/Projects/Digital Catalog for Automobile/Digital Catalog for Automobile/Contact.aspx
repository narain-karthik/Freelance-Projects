<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Contact.aspx.vb" Inherits="Digital_Catalog_for_Automobile.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* Container styling */
        .contact-container {
            max-width: 960px;
            margin: 40px auto; /* Increased margin for spacing */
            padding: 30px;
            background-color: #fff; /* White background for contrast */
            box-shadow: 0 4px 20px rgba(0, 0, 0, 0.1); /* Slightly stronger shadow */
            border-radius: 10px; /* Softer corners */
        }

        /* Header styling */
        .header {
            text-align: center;
            margin-bottom: 40px;
        }
        .header h1 {
            font-size: 2.5rem;
            color: #333; /* Dark gray from Master page */
            margin-bottom: 10px;
        }
        .header p {
            color: #666; /* Medium gray */
            font-size: 1.1rem; /* Slightly larger for readability */
            margin-bottom: 0;
        }

        /* Form container styling */
        .form-container {
            display: flex;
            flex-wrap: wrap;
            gap: 30px;
            justify-content: space-between;
        }
        .form-group {
            width: calc(50% - 15px); /* Two columns */
            margin-bottom: 25px;
        }
        label {
            display: block;
            margin-bottom: 8px;
            color: #333;
            font-weight: 600;
            font-size: 1rem;
        }
        .form-control {
            width: 100%;
            padding: 12px;
            border: 1px solid #ddd;
            border-radius: 5px;
            box-sizing: border-box;
            font-size: 1rem;
            transition: border-color 0.3s ease, box-shadow 0.3s ease;
        }
        .form-control:focus {
            border-color: #663399; /* Purple from Master page */
            box-shadow: 0 0 5px rgba(102, 51, 153, 0.3); /* Subtle purple glow */
            outline: none;
        }
        textarea.form-control {
            height: 120px;
            resize: vertical;
        }
        .file-upload {
            margin-top: 10px;
        }
        .file-upload p {
            font-size: 0.9rem;
            color: #666;
            margin: 5px 0 0;
        }

        /* Submit button styling */
        .submit-btn {
            text-align: center;
            margin-top: 30px;
            width: 100%;
        }
        .btn-submit {
            padding: 12px 35px;
            background-color: #663399; /* Purple from Master page */
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 1.1rem;
            font-weight: 600;
            transition: background-color 0.3s ease, transform 0.2s ease;
        }
        .btn-submit:hover {
            background-color: #552288; /* Darker purple for hover */
            transform: translateY(-2px); /* Slight lift effect */
        }

        /* Contact details styling */
        .contact-details {
            width: calc(30% - 15px);
            padding: 25px;
            background-color: #f7f7f7; /* Light gray */
            border: 1px solid #ddd;
            border-radius: 10px;
            margin: 40px auto 0; /* Centered with top spacing */
        }
        .contact-details h3 {
            margin-top: 0;
            font-size: 1.6rem;
            color: #333;
        }
        .contact-details p {
            font-size: 1rem;
            margin-bottom: 15px;
            color: #444;
            line-height: 1.5;
        }
        .contact-details img {
            max-width: 100%;
            height: auto;
            display: block;
            margin-bottom: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }
        .contact-details a {
            color: #663399; /* Purple from Master page */
            text-decoration: none;
            font-weight: 600;
        }
        .contact-details a:hover {
            text-decoration: underline;
        }

        /* Responsive adjustments */
        @media (max-width: 768px) {
            .contact-container {
                margin: 20px auto;
                padding: 20px;
            }
            .form-group {
                width: 100%; /* Full width on smaller screens */
            }
            .contact-details {
                width: 100%;
                margin: 20px auto 0;
            }
            .header h1 {
                font-size: 2rem;
            }
            .header p {
                font-size: 1rem;
            }
            .btn-submit {
                padding: 10px 25px;
                font-size: 1rem;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contact-container">
        <div class="header">
            <h1>Contact Us</h1>
            <p>We’d love to hear from you. Share your thoughts, questions, or inquiries with us!</p>
        </div>

        <div class="form-container">
            <div class="form-group">
                <label for="name">Name*</label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" Required="True" Placeholder="Enter your full name" aria-label="Full Name"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="contact">Contact No.*</label>
                <asp:TextBox ID="txtContact" runat="server" CssClass="form-control" Required="True" MaxLength="10" Pattern="[0-9]{10}" Placeholder="10-digit number" aria-label="Contact Number"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="email">Email ID*</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Type="email" Required="True" Placeholder="example@domain.com" aria-label="Email Address"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="city">City*</label>
                <asp:TextBox ID="txtCity" runat="server" CssClass="form-control" Required="True" Placeholder="Enter your city" aria-label="City"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="subject">Subject*</label>
                <asp:DropDownList ID="ddlSubject" runat="server" CssClass="form-control" Required="True">
                    <asp:ListItem Text="Choose your subject" Value="" />
                    <asp:ListItem Text="Support" Value="support" />
                    <asp:ListItem Text="Feedback" Value="feedback" />
                    <asp:ListItem Text="General Inquiry" Value="inquiry" />
                    <asp:ListItem Text="Vehicle Inquiry" Value="vehicle" />
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="message">Message*</label>
                <asp:TextBox ID="txtMessage" runat="server" CssClass="form-control" TextMode="MultiLine" Required="True" Placeholder="Type your message here" aria-label="Your Message"></asp:TextBox>
            </div>
            <div class="form-group file-upload">
                <label for="file">Attach Files (Optional)</label>
                <asp:FileUpload ID="fileUpload" runat="server" CssClass="form-control" Accept=".jpeg,.png,.pdf" aria-label="Attach File" />
                <p>Note: Max file size 1MB. Accepted formats: JPEG, PNG, PDF.</p>
            </div>

            <div class="submit-btn">
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" CssClass="btn-submit" OnClick="SubmitButton_Click" />
            </div>
        </div>

        <div class="contact-details">
            <img src="image/letter.png" alt="Auto Haven Contact Image" />
            <h3>Auto Haven Private Limited</h3>
            <p><strong>Registered Address:</strong><br>
                32/33 A, Deonar Village Road, Opp. Metal Box Company, Govandi East, Coimbatore-400088, Tamil Nadu, India</p>
            <p><strong>Grievance & Nodal Officer:</strong><br>
                Ms. Simantini Budukh, General Counsel & Company Secretary</p>
            <p><strong>Contact Details:</strong><br>
                +91 8182-881881<br>
                <a href="mailto:contact@autohaven.in">contact@autohaven.in</a></p>
        </div>
    </div>
</asp:Content>
