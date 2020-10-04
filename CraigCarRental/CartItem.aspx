<%@ Page Title = "Shoping Cart" Language="C#" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "CartItem.aspx.cs" Inherits = "CraigCarRental.CartItem" %>

 <asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2> ITEM(S) IN CART </h2> 
    <hr>
    <h1> <asp:button id = "buttonInCart" runat="server" style = "width:100%" /></h1> 
    <div  class=" row" style="text-align:center">
        <div class="col-md-4"> 
            <div class="productCard"> 
                <div class="product" id="SKU_1245">
                    <img class="img-fluid"  alt = ""  src="Images/Products/BMW/bmw1.png" />
                    <label id = "item1"  runat = "server" >
                       
                    </label>
                    <br> <asp:button class="addToCartButton" id="SKU1245" Text = "Remove" runat = "server" OnClick="Remove"    /> 
                </div> 
                <hr>
                <div class="product" id="SKU_1315">
                    <img class="img-fluid" alt = "" src="Images/Products/BMW/bmw4.png" />
                    <label id = "item2">
                        ID: SKU-1315
                        <br>Name: BMW M3 Sedan
                        <br>Description: 
                        <br>Category: BMW
                        <br>Unit price: $9,000
                        <br> <asp:Button class="addToCartButton" ID="SKU1315" Text = "Remove" runat = "server" OnClick="Remove"    />
                    </label>
                </div> 
            </div> 
        </div> 
        <div class="col-md-4"> 
            <div class="productCard"> 
                <div class="product" id="SKU_2265">
                    <img class="img-fluid" alt = "" src="Images/Products/BENZ/benz1.png"  />
                    <label id = "item3">
                        ID: SKU-2265
                        <br>Name: Mercedes-Benz E-Class
                        <br>Description: 
                        <br>Category: Mercedes-Benz
                        <br>Unit price: $11,000
                        <br><asp:button class="addToCartButton" id="SKU2265" Text = "Remove" runat = "server"  OnClick="Remove"   />
                    </label>
                </div> 
                <hr>
                <div class="product" id="SKU_1705">
                    <img class="img-fluid" alt = ""src="Images/Products/BENZ/benz2.png"  />
                    <label id = "item4">
                        ID: SKU-1705 
                        <br>Name: Mercedes-Benz GLC Coupe
                        <br>Description: 
                        <br>Category: Mercedes-Benz
                        <br>Unit price: $10,500
                        <br><asp:button class="addToCartButton" id="SKU1705" Text = "Remove" runat = "server"  OnClick="Remove"   />
                    </label>
                </div> 
            </div> 
        </div> 
        <div class="col-md-4"> 
            <div class="productCard"> 
                <div class="product" id="SKU_4145">
                    <img class="img-fluid" alt = "" src="Images/Products/AUDI/audi1.png"  />
                    <label id = "item5">
                        ID: SKU-4145 
                        <br>Name: Audi TT coupe
                        <br>Description: 
                        <br>Category: Audi
                        <br>Unit price: $11,500
                        <br><asp:button class="addToCartButton" id="SKU4145" Text = "Remove" runat = "server"  OnClick="Remove"   />
                    </label>
                </div> 
                <hr>
                <div class="product" id="SKU_3261">
                    <img class="img-fluid" alt = "" src="Images/Products/AUDI/audi2.png"  />
                    <label id = "item6">
                        ID: SKU-3261 
                        <br>Name: Audi A5 convertible
                        <br>Description: 
                        <br>Category: Audi
                        <br>Unit price: $9,500
                        <br><asp:button class="addToCartButton" id="SKU3261" Text = "Remove" runat = "server" OnClick="Remove"   />
                    </label>
                </div> 
            </div> 
        </div> 
    </div>
 </asp:Content>