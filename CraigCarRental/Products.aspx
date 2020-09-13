<%@ Page Title = "Products" Language="C#" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "Products.aspx.cs" Inherits="CraigCarRental.Products" %>


 <asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2> Products </h2> 
    <div  class=" row" style="text-align:center">
        <div class="col-md-4"> 
            <div class="productCard"> 
                <div class="product" id="SKU_1245">
                    <img   alt = ""  width = "100%" src="Images/Products/BMW/bmw1.png" />
                    <label>
                        ID: SKU-1245 
                        <br>Name: BMW X6
                        <br>Description: 
                        <br>Category: BMW
                        <br>Unit price: $20,000
                    </label>
                </div> 
                <hr>
                <div class="product" id="SKU_1315">
                    <img  alt = ""  width = "100%" src="Images/Products/BMW/bmw4.png" />
                    <label>
                        ID: SKU-1315
                        <br>Name: BMW M3 Sedan
                        <br>Description: 
                        <br>Category: BMW
                        <br>Unit price: $20,000
                    </label>
                </div> 
            </div> 
        </div> 
        <div class="col-md-4"> 
            <div class="productCard"> 
                <div class="product" id="SKU_2265">
                    <img  alt = "" width = "100%" src="Images/Products/BENZ/benz1.png"  />
                    <label>
                        ID: SKU-2265
                        <br>Name: Mercedes-Benz E-Class
                        <br>Description: 
                        <br>Category: Mercedes-Benz
                        <br>Unit price: $20,000
                    </label>
                </div> 
                <hr>
                <div class="product" id="SKU_1705">
                    <img  alt = "" width = "100%" src="Images/Products/BENZ/benz2.png"  />
                    <label>
                        ID: SKU-1705 
                        <br>Name: Mercedes-Benz GLC Coupe
                        <br>Description: 
                        <br>Category: Mercedes-Benz
                        <br>Unit price: $20,000
                    </label>
                </div> 
            </div> 
        </div> 
        <div class="col-md-4"> 
            <div class="productCard"> 
                <div class="product" id="SKU_4145">
                    <img   alt = "" width = "100%" src="Images/Products/AUDI/audi1.png"  />
                    <label>
                        ID: SKU-4145 
                        <br>Name: Audi TT coupe
                        <br>Description: 
                        <br>Category: Audi
                        <br>Unit price: $20,000
                    </label>
                </div> 
                <hr>
                <div class="product" id="SKU_3261">
                    <img alt = "" width = "100%" src="Images/Products/AUDI/audi2.png"  />
                    <label>
                        ID: SKU-3261 
                        <br>Name: Audi A5 convertible
                        <br>Description: 
                        <br>Category: Audi
                        <br>Unit price: $20,000
                    </label>
                </div> 
            </div> 
        </div> 
    </div>
 </asp:Content>