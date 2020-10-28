<%@ Page Title = "Login" Language="C#" enableEventValidation="true" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "Default.aspx.cs" Inherits="CraigCarRental.Default" %>

<asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2>LOGIN</h2> 
    <div class="form" style="width:40%; margin-left:auto; margin-right:auto;">
        <asp:Label class=""  id ="loginLabel" runat="server" Text = ""/> 
        <asp:TextBox type="text" name="Username" CssClass="" id="Username" placeholder="Username" runat="server" ></asp:TextBox>
        <asp:TextBox type="text" name="Pasword" CssClass="" id="Pasword"   placeholder="Pasword" runat="server"></asp:TextBox> 
        <asp:Button  class="LoginButton"  ID="LoginButton" runat="server"  Text="LOGIN"  OnClick="LoginUser"/>
    </div><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>
</asp:Content>