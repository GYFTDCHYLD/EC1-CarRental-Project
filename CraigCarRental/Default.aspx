<%@ Page Title = "Home" Language="C#" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "Default.aspx.cs" Inherits = "CraigCarRental.Default" %>

 <asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2> Featured products </h2> 
    <div class="row" style="text-align:center">
        <div class="col-md-6" > 
            <hr>
            <div class="featuredProduct" id="SKU_1245">
                <img class="featuredImage" alt = ""  width = "100%" src="Images/Products/BMW/bmw1.png" />
                <label>
                    ID: SKU-1245 
                    <br>Name: BMW X6
                    <br>Description: 
                    <br>Category: BMW
                    <br>Unit price: $12,000
                    <br> <input  class = "numberOfDaysRentedInput" id="daysRented" placeholder="Days"  Max="10" Min="1"   type="number"  OnClick="ClickedDays"/><asp:button class="addToCartButton" id="SKU1245" Text = "ADD TO CART" runat = "server" OnClick="Clicked"   />
                </label>
            </div>
        </div> 
        <div class="col-md-6"> 
            <hr>
            <div class="featuredProduct" id="SKU_4145">
                <img class="featuredImage"  alt = "" width = "100%" src="Images/Products/AUDI/audi1.png"  />
                <label>
                    ID: SKU-4145 
                    <br>Name: Audi TT coupe
                    <br>Description: 
                    <br>Category: Audi
                    <br>Unit price: $11,500
                    <br><input class = "numberOfDaysRentedInput" id="daysRented" placeholder="Days"  Max="10" Min="1"   type="number" /><asp:button class="addToCartButton" id="SKU4145" Text = "ADD TO CART" runat = "server" OnClick="Clicked"   /> 
                </label>
            </div>    
        </div> 
    </div>
    <hr>
 </asp:Content>