<%@ Page Title = "Invoice" Language="C#" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "Invoice.aspx.cs" Inherits = "CraigCarRental.Invoice" %>

 <asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2> INVOICE </h2> 
    <hr>

    <center><asp:Label class="CartTotal"  id ="cartTotal" runat="server" Text = ""/>  
    <asp:GridView CssClass = "GridView" id="GridView1" runat="server" AutoGenerateColumns="false"  > 
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
        </Columns>
    </asp:GridView> 

    </center> 
   
     <br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>
 </asp:Content>