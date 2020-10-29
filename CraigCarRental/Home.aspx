<%@ Page Title = "Home" Language="C#" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "Home.aspx.cs" Inherits = "CraigCarRental.Home" %>

 <asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2> Featured products </h2> 
    <div class="row" style="text-align:center">
        <div class="col-md-6" > 
            <hr>
            <div class="featuredProduct">
                <img class="featuredImage" alt = ""  width = "100%" src="Images/Products/BMW/bmw1.png" />
                <label>
                    ID: SKU1245 
                    <br>Name: BMW X6
                    <br>Description: 
                    <br>Category: BMW
                    <br>Unit price: $12,000
                    <br>
                </label>
                <p>
                    <asp:TextBox CssClass="dataInput" ID="StartDate1" placeholder="Start Date" runat="server" ReadOnly="true" OnTextChanged = "ProcessDate" ></asp:TextBox>
                    <asp:TextBox CssClass="dataInput" ID="EndDate1" placeholder="End Date" runat="server" ReadOnly="true" OnTextChanged = "ProcessDate" ></asp:TextBox>
                    <asp:button class="addToCartButton" id="SKU1245" Text = "ADD TO CART" runat = "server" OnClick="Clicked"   />
                </p><br>
            </div>
        </div> 
        <div class="col-md-6"> 
            <hr>
            <div class="featuredProduct">
                <img class="featuredImage"  alt = "" width = "100%" src="Images/Products/AUDI/audi1.png"  />
                <label>
                    ID: SKU4143 
                    <br>Name: Audi TT coupe
                    <br>Description: 
                    <br>Category: Audi
                    <br>Unit price: $11,500
                </label>
                <p>
                    <asp:TextBox CssClass="dataInput" ID="StartDate2" placeholder="Start Date" runat="server" ReadOnly="true" OnTextChanged = "ProcessDate"></asp:TextBox>
                    <asp:TextBox CssClass="dataInput" ID="EndDate2" placeholder="End Date" runat="server" ReadOnly="true" OnTextChanged = "ProcessDate" ></asp:TextBox>
                    <asp:button class="addToCartButton" id="SKU4143" Text = "ADD TO CART" runat = "server" OnClick="Clicked" />
                </p><br>
            </div>    
        </div> 
    </div>
    <hr>
 </asp:Content>
