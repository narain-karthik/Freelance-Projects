<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Product.aspx.vb" Inherits="Graments.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Products</title>
    <style>
        .product-container {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            grid-gap: 20px;
            padding: 20px;
        }

        .product {
            border: 1px solid #ccc;
            padding: 20px;
            text-align: center;
            box-shadow: 2px 2px 5px rgba(0,0,0,0.1);
            border-radius: 8px;
            transition: transform 0.2s;
            background-color: #f9f9f9;
        }

        .product:hover {
            transform: scale(1.05);
        }

        .product img {
            max-width: 100%;
            height: auto;
            margin-bottom: 10px;
            border-radius: 4px;
        }

        .product h3 {
            margin-bottom: 5px;
            color: #333;
        }

        .product p {
            margin-bottom: 10px;
        }

        .quantity-selector {
            display: flex;
            align-items: center;
            margin-bottom: 10px;
            justify-content: center;
        }

        .quantity-input {
            width: 30px;
            padding: 5px;
            margin-left: 5px;
            border: 1px solid #ccc;
            border-radius: 4px;
            text-align: center;
        }

        .buy-button {
            display: inline-block;
            padding: 10px 20px;
            background-color: #007bff;
            color: white;
            text-decoration: none;
            border-radius: 5px;
            transition: background-color 0.3s;
            margin-top: 10px; /* Space from quantity */
        }

        .buy-button:hover {
            background-color: #0056b3;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align: center; color: #CC3300; font-family: 'Times New Roman', Times, serif; font-size: xx-large; background-color: #CCCCCC">Our Products</h1>
    <div class="product-container">

        <div class="product">
            <img src="new/1.jpg" alt="Farm Fresh Milk">
            <h3>Men's Shirts</h3>
            
            <div class="quantity-selector">
                
            </div>
            
        </div>

        <div class="product">
            <img src="new/2.jpg" alt="Buffalo Milk">
            <h3>Men's Shirts</h3>
            
            <div class="quantity-selector">
                
            </div>
           
        </div>

        <div class="product">
            <img src="new/3.jpg" alt="Farm Fresh Toned Milk">
            <h3>Men's Shirts</h3>
            
            <div class="quantity-selector">
                
            </div>
           
        </div>

        <div class="product">
            <img src="new/6.jpg" alt="Nature Cow Ghee">
            <h3>Boxer</h3>
            
            <div class="quantity-selector">
                
            </div>
           
        </div>

        <div class="product">
            <img src="new/1 (1).jpg" alt="Buffalo Ghee">
            <h3>Women's Tunics</h3>
            
            <div class="quantity-selector">
                
            </div>
        
        </div>

        <div class="product">
            <img src="new/2 (1).jpg" alt="Paneer">
            <h3>Women's Tunics</h3>
            
            <div class="quantity-selector">
               
            </div>
            
        </div>

        <div class="product">
            <img src="new/3 (1).jpg" alt="Curd">
            <h3>Women's Tunics</h3>
            
            <div class="quantity-selector">
              
            </div>
            
        </div>

        <div class="product">
            <img src="new/1 (2).jpg" alt="Curd">
            <h3>Women's Pyjamaset</h3>
         
            <div class="quantity-selector">
              
            </div>
            
        </div>


        <div class="product">
            <img src="new/1 (3).jpg" alt="Curd">
            <h3>Babies Shirts</h3>
           
            <div class="quantity-selector">
              
            </div>
           
        </div>

        <div class="product">
            <img src="new/1 (3).jpg" alt="Curd">
            <h3>Babies Shirts</h3>
            
            <div class="quantity-selector">
                
            </div>
            
        </div>

      <div class="product">
            <img src="new/1 (4).jpg" alt="Curd">
            <h3>Babies Sets</h3>
            
            <div class="quantity-selector">
              
            </div>
            
        </div>


        <div class="product">
            <img src="new/1 (5).jpg" alt="Curd">
            <h3>Accessories Muslin wraps</h3>
            
            <div class="quantity-selector">
                
            </div>
          
        </div>



    </div>
</asp:Content>
