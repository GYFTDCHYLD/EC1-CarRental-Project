<%@ Page Title = "Shoping Cart" Language="C#" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "CartItem.aspx.cs" Inherits = "CraigCarRental.CartItem" %>

 <asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2> SHOPPING CART </h2> 
    <hr>
 
    <center><asp:Label class="CartTotal"  id ="cartTotal" runat="server" Text = ""/>  
    <asp:GridView CssClass = "GridView" id="GridView1" runat="server" AutoGenerateColumns="false" OnRowDeleting="GridView1_RowDeleting" > 
        <Columns>
            <asp:TemplateField HeaderText="PRODUCT ID">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label1" runat="server" Text = '<%# Bind("productID") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PRODUCT NAME">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label2" runat="server" Text = '<%# Bind("productName") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="UNIT PRICE">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label3" runat="server" Text = '<%# Bind("productPrice") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField> 
            <asp:TemplateField HeaderText="DAYS RENTED">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label4" runat="server" Text = '<%# Bind("DaysRented") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="SUB-TOTAL">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label5" runat="server" Text = '<%# Bind("subTotal") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:CommandField ShowDeleteButton = "true" />  
        </Columns>
    </asp:GridView> 
    </center> 
    <hr><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>
 </asp:Content>