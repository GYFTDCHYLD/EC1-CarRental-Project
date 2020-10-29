<%@ Page Title = "Products" Language="C#" enableEventValidation="true" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "Products.aspx.cs" Inherits="CraigCarRental.Products" %>


 <asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2> Products </h2> 
    <div  class=" row" style="text-align:center">
         <asp:DataList id= "PRODUCTS" runat="server" OnItemCommand="PRODUCTS_ItemCommand" RepeatColumns = "3"  CssClass="" CellPadding = "2">
            <ItemTemplate  >
                <table >
                    <div class="product" style="margin: 10px; position: relative; text-decoration:none">  
                    
                        <asp:Image CssClass="productImage" runat="server" ImageUrl='<%#Eval("productImage") %>'></asp:Image>
                   
                        <br>Product ID: <%#Eval("productID") %>
                        
                        <br>Product Name: <%#Eval("productName") %>
                   
                        <br>Price : $<%#Eval("productPrice") %>
                    
                        <br>Category : <%#Eval("Category") %>
                   
                        <br>Description :<%#Eval("Description") %><hr>
                     
                        <p>
                            <input type="text" name="StartDate1" class="dataInput" id="StartDate1" placeholder="Start Date" ReadOnly="true" />
                            <input type="text" name="EndDate1"   class="dataInput" id="EndDate1"   placeholder="End Date"   ReadOnly="true" />
                            <asp:Button  class="addToCartButton"  ID="addToCartButton" runat="server" CommandName="addToCart" CommandArgument='<%#Eval("productID")%>' Text="ADD TO CART" CausesValidation="True" UseSubmitBehavior="false" />
                        </p> 
                        
                    </div>    
                </table>
            </ItemTemplate> 
        </asp:DataList>
    </div>
 </asp:Content>