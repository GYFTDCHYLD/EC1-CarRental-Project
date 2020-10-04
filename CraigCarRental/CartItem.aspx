<%@ Page Title = "Shoping Cart" Language="C#" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "CartItem.aspx.cs" Inherits = "CraigCarRental.CartItem" %>
<asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2> ITEM(S) IN CART </h2> 
    <hr>
    <h1> <asp:button id = "buttonInCart" runat="server" style = "width:100px" /></h1> 
    <div>
         <% 
            for(int i = 0; i < 10; i++){ %>
                <div class="cell">
                   
                </div> 
            <% 
        } %>
    </div>
     
</asp:Content>