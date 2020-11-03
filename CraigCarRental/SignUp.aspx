<%@ Page Title = "SignUp" Language="C#" enableEventValidation="true" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "SignUp.aspx.cs" Inherits="CraigCarRental.SignUp" %>

<asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2>SignUp</h2> 
    <div class="form">
        <asp:Label class=""  id ="loginLabel" runat="server" Text = ""/> 
        <asp:TextBox TextMode="SingleLine" type="text" name="firstName" CssClass="" id="firstName" placeholder="First Name" runat="server" ></asp:TextBox> <br>
        <asp:TextBox TextMode="SingleLine" type="text" name="lastName" CssClass="" id="lastName" placeholder="Last Name" runat="server" ></asp:TextBox> <br>
        <asp:TextBox TextMode="SingleLine" type="text" name="Username" CssClass="" id="Username" placeholder="Username" runat="server" ></asp:TextBox> <br>
        <asp:TextBox TextMode="Password" name="Pasword" CssClass="" id="Pasword"   placeholder="Pasword" runat="server"></asp:TextBox>  <br>
        <asp:TextBox TextMode="Password" name="confirmPasword" CssClass="" id="confirmPasword"   placeholder="Confirm Pasword" runat="server"></asp:TextBox> <br> <br> 
        <asp:Button  class="SignUpButton"  ID="SIGNUP" runat="server"  Text=" Create Account "  OnClick="createAccount"/>
    </div><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>
</asp:Content>