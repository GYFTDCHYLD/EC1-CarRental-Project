<%@ Page Title = "Order History" Language="C#" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "OrderHistory.aspx.cs" Inherits = "CraigCarRental.OrderHistory" %>

 <asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2> ORDER HISTORY</h2> 
     <asp:Label id="deletedId" CssClass = "cartLabel"  runat="server" />
    <hr>
    
    <asp:GridView CssClass = "GridView" id="orderHistory" runat="server" AutoGenerateColumns="false" > 
        <Columns>
            <asp:TemplateField HeaderText="ORDER ID">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label4h" runat="server" Text = '<%# Bind("OrderID") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PRODUCT IMAGE">
                <ItemTemplate>
                    <asp:Image class="tableRow" id="Imageh" Width="80" runat="server" ImageUrl='<%#Bind("productImage") %>'></asp:Image>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="UNIT PRICE">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label1h" runat="server" Text = '<%# Bind("productPrice") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField> 
            <asp:TemplateField HeaderText="START DATE">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label2h" runat="server" Text = '<%# Bind("startDate") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
             <asp:TemplateField HeaderText="END DATE">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label3h" runat="server" Text = '<%# Bind("endDate") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="SUB-TOTAL">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label5h" runat="server" Text = '<%# Bind("subTotal") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
        </Columns>
    </asp:GridView> 
    <br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>
 </asp:Content>