<%@ Page Title = "Shoping Cart" Language="C#" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "CartItem.aspx.cs" Inherits = "CraigCarRental.CartItem" %>

 <asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2> ITEM(S) IN CART </h2> 
    <hr>
    <h1> <asp:button id = "buttonInCart" runat="server" style = "width:100%" /></h1> 
    <center>  
    <asp:GridView id="GridView1" style="text-align: center; padding: 20px" runat="server" AutoGenerateColumns="false" OnRowDeleting="GridView1_RowDeleting" > 
        <Columns>
            <asp:TemplateField HeaderText="PRODUCT ID">
                <ItemTemplate class = "ItemTemplate">
                    <asp:Label id ="Label1" runat="server" Text = '<%# Bind("productID") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PRODUCT NAME">
                <ItemTemplate>
                    <asp:Label id ="Label2" runat="server" Text = '<%# Bind("productName") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="UNIT PRICE">
                <ItemTemplate>
                    <asp:Label id ="Label3" runat="server" Text = '<%# Bind("productPrice") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField> 
            <asp:TemplateField HeaderText="DAYS RENTED">
                <ItemTemplate>
                    <asp:Label id ="Label4" runat="server" Text = '<%# Bind("DaysRented") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="SUB-TOTAL">
                <ItemTemplate>
                    <asp:Label id ="Label5" runat="server" Text = '<%# Bind("subTotal") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
           
            <asp:CommandField ShowDeleteButton = "true" />
                
        </Columns>
    </asp:GridView> 
    </center> 
 </asp:Content>