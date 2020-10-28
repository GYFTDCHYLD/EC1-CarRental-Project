<%@ Page Title = "ADMIN PANEL" Language="C#" enableEventValidation="true" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "AdminPanel.aspx.cs" Inherits="CraigCarRental.AdminPanel" %>

<asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
        <h2>ADMIN PANEL</h2> 
    <asp:GridView CssClass = "GridView" id="GridView2" runat="server" AutoGenerateColumns="false" OnRowDeleting="GridView2_RowDeleting" > 
        <Columns>
            <asp:TemplateField HeaderText="ID">
                <ItemTemplate>
                   <asp:Label class="tableRow" id="Label1" runat="server" Text='<%#Bind("productID") %>'></asp:Label>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="NAME">
                <ItemTemplate>
                    <asp:Label class="tableRow" id="Label2" runat="server" Text='<%#Bind("productName") %>'></asp:Label>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PRICE">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label3" runat="server" Text = '<%# Bind("productPrice") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CATEGORY">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label4" runat="server" Text = '<%# Bind("Category") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
             <asp:TemplateField HeaderText="DESCRIPTION">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label5" runat="server" Text = '<%# Bind("Description") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="IMAGE">
                <ItemTemplate>
                    <asp:Image class="tableRow" id="Image1" Width="80" runat="server" ImageUrl='<%#Bind("productImage") %>'></asp:Image>
                </ItemTemplate> 
            </asp:TemplateField>
             
            <asp:CommandField ShowDeleteButton = "true" DeleteText="Remove" ButtonType="Link" />  
        </Columns>
    </asp:GridView> 
    <br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>
 </asp:Content>