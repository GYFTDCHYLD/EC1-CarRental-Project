<%@ Page Title = "Login" Language="C#" enableEventValidation="true" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "Default.aspx.cs" Inherits="CraigCarRental.Default" %>

<asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2>LOGIN</h2> 
    <div class="form">
        <asp:Label class=""  id ="loginLabel" runat="server" Text = ""/> 
        <asp:TextBox TextMode="SingleLine" type="text" name="Username" CssClass="" id="Username" placeholder="Username" runat="server" ></asp:TextBox> <br>
        <asp:TextBox TextMode="Password" name="Pasword" CssClass="" id="Pasword"   placeholder="Pasword" runat="server"></asp:TextBox> <br> <br>
        <asp:Button  class="LoginButton"  ID="LoginButton" runat="server"  Text=" LOGIN "  OnClick="LoginUser"/>
        <asp:Button  class="SignUpButton"  ID="SignUp" runat="server"  Text=" SIGNUP "  PostBackUrl = "SignUp.aspx"/>
    </div><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>
</asp:Content>