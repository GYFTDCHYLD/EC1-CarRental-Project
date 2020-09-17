<%@ Page Title = "Contact" Language="C#" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "Contact.aspx.cs" Inherits="CraigCarRental.Contact"  %>

 <asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2> Contact Us </h2> 
    <div  class=" row" style="text-align:center">
        <div class="col-md-12" > 
            <ul style = "overflow:hidden; margin-bottom: 350px; margin-top:40px;">
                <li><a href = "mailto:craigscarrental@gmail.com"><img   alt = ""   width ="20em" src="Images/mail.png" /> craigscarrental@gmail.com</a> </li> 
                <li> <a href="tel:18765829083"> <img   alt = ""   width ="20em" src="Images/phone.png" /> (876) 535-8834</a> </li>  
                <li><a href="https://api.whatsapp.com/send?phone=18765358834"> <img   alt = ""  width ="20em" src="Images/whatsApp.png" /> WhatsApp</a> </li> 
            </ul> 
        </div> 
    </div>
 </asp:Content>
 