<%@ Page Title = "ADMIN PANEL" Language="C#" enableEventValidation="true" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "AdminPanel.aspx.cs" Inherits="CraigCarRental.AdminPanel" %>

<asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
        <h2>ADMIN PANEL</h2> 
    <asp:GridView CssClass = "GridView" id="ProductGrid" runat="server" AutoGenerateColumns="false" OnRowDeleting="AdminGridUpdate" > 
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
            <asp:CommandField ShowDeleteButton = "true" DeleteText="SELECT" ButtonType="Link" />  
        </Columns>
    </asp:GridView> 
    <div class = "UptadeFieldDiv">
        <asp:TextBox class = "updateField" id="id" placeholder="id"  runat="server" ></asp:TextBox> 
        <asp:TextBox class = "updateField" id="name" placeholder="name"  runat="server" ></asp:TextBox>
        <asp:TextBox class = "updateField" id="price" placeholder="price"  runat="server" ></asp:TextBox>  
        <asp:TextBox class = "updateField" id="category" placeholder="category"  runat="server" ></asp:TextBox> 
        <asp:TextBox class = "updateField" id="description" placeholder="description"  runat="server" ></asp:TextBox> 
        <asp:TextBox class = "updateField" id="image" placeholder="image"  runat="server" ></asp:TextBox><br>
        <asp:button style="" id="add" Text = "ADD CAR" runat = "server" OnClick="addData" /> 
        <asp:button style="" id="update" Text = "UPDATED CAR" runat = "server"  UseSubmitBehavior="false" OnClick="updateData"  /> 
        <asp:button style="" id="delete" Text = "DELETED CAR" runat = "server"  UseSubmitBehavior="false" OnClick="deleteData"  /> 
    </div>
    <br><br><br><br><br><br><br><br>
      <asp:GridView CssClass = "GridView" id="UserGrid" runat="server" AutoGenerateColumns="false" OnRowDeleting="UserGridUpdate" > 
        <Columns>
            <asp:TemplateField HeaderText="USER ID">
                <ItemTemplate>
                   <asp:Label class="tableRow" id="Label5" runat="server" Text='<%#Bind("UserID") %>'></asp:Label>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="FIRST NAME">
                <ItemTemplate>
                    <asp:Label class="tableRow" id="Label6" runat="server" Text='<%#Bind("Firstname") %>'></asp:Label>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="LAST NAME">
                <ItemTemplate>
                    <asp:Label class="tableRow" id="Label7" runat="server" Text='<%#Bind("Lastname") %>'></asp:Label>
                </ItemTemplate> 
            </asp:TemplateField>
             <asp:TemplateField HeaderText="USERNAME">
                <ItemTemplate>
                    <asp:Label class="tableRow" id="Label8" runat="server" Text='<%#Bind("Username") %>'></asp:Label>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PASSWORD">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label9" runat="server" Text = '<%# Bind("Passwrd") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="USER TYPE">
                <ItemTemplate>
                    <asp:Label class="tableRow" id ="Label10" runat="server" Text = '<%# Bind("UserType") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:CommandField ShowDeleteButton = "true" DeleteText="SELECT" ButtonType="Link" />  
        </Columns>
    </asp:GridView>
     <div class = "UptadeFieldDiv">
        <asp:TextBox class = "updateField" id="uid" placeholder="id"  runat="server"  ReadOnly="true" ></asp:TextBox> 
        <asp:TextBox class = "updateField" id="Fname" placeholder="Firstname"  runat="server" ></asp:TextBox>
        <asp:TextBox class = "updateField" id="Lname" placeholder="Lastname"  runat="server" ></asp:TextBox>  
        <asp:TextBox class = "updateField" id="Uname" placeholder="Username"  runat="server" ></asp:TextBox> 
        <asp:TextBox class = "updateField" id="Pass" placeholder="Password"  runat="server" ></asp:TextBox> 
        <asp:TextBox class = "updateField" id="type" placeholder="User Type"  runat="server" ></asp:TextBox> <br>
        <asp:button style="" id="addUser" Text = "ADD USER" runat = "server" OnClick="addUserData" /> 
        <asp:button style="" id="updateUser" Text = "UPDATE USER" runat = "server"  UseSubmitBehavior="false" OnClick="updateUserData"  /> 
        <asp:button style="" id="deleteUser" Text = "DELETE USER" runat = "server"  UseSubmitBehavior="false" OnClick="deleteUserData"  /> 
    </div>
    <br><br><br><br><br><br><br><br><br><br>
 </asp:Content>