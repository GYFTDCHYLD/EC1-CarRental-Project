<%@ Page Title = "Shoping Cart" Language="C#" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "CartItem.aspx.cs" Inherits = "CraigCarRental.CartItem" %>

 <asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2> SHOPPING CART </h2> 
     <asp:Label id="deletedId" CssClass = "cartLabel"  runat="server" />
    <hr>

    <center><asp:Label class="CartTotal"  id ="cartTotal" runat="server" Text = ""/>  
    <asp:GridView CssClass = "GridView" id="GridView1" runat="server" AutoGenerateColumns="false" OnRowDeleting="GridView1_RowDeleting" > 
        <Columns>
            <asp:TemplateField HeaderText="PRODUCT IMAGE">
                <ItemTemplate>
                    <asp:Image class="tableRow" id="Image1" Width="80" runat="server" ImageUrl='<%#Bind("productImage") %>'></asp:Image>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="UNIT PRICE">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label3" runat="server" Text = '<%# Bind("productPrice") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField> 
            <asp:TemplateField HeaderText="START DATE">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label4" runat="server" Text = '<%# Bind("startDate") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
             <asp:TemplateField HeaderText="END DATE">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label5" runat="server" Text = '<%# Bind("endDate") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DAYS RENTED">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label6" runat="server" Text = '<%# Bind("DaysRented") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="SUB-TOTAL">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label7" runat="server" Text = '<%# Bind("subTotal") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:CommandField ShowDeleteButton = "true" DeleteText="Remove" ButtonType="Link" />  
        </Columns>
    </asp:GridView> 

    </center> 
     <asp:Button style=" float: right" class="addToCartButton" id="Checkout"  runat="server" CommandName="Checkout" CommandArgument='<%#Bind("UserID")%>' Text="CHECKOUT" CausesValidation="True" UseSubmitBehavior="false" OnClick="CheckoutItem" />
     <br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>
 </asp:Content>