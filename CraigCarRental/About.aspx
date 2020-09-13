<%@ Page Title = "About" Language="C#" MasterPageFile = "~/Master.master"  AutoEventWireup = "true" CodeBehind = "About.aspx.cs" Inherits="CraigCarRental.About"  %>

 <asp:Content ID="body" ContentPlaceHolderID="bodyContent" runat="server">
    <h2> About Us</h2> 
    <div id="" class="row" style="text-align:center">
        <div class="col-md-4" > 
            <img id="CEO" alt = "logo image" src="Images/CEO.png" />
            <h5> CEO: CRAIG REID </h5>
            <br><br>
        </div> 
        <div class="col-md-4"> 
            <br><br>
             <img style="width:100%" alt = "logo image" src="Images/logo1.png" width ="20em"  align ="left" />
            <strong>Craig's Car Rental</strong> was founded in 2020 by CEO <strong>Craig Reid</strong>, as a means of providing Luxurious rental cars at an affordabe price.
        </div> 
        <div class="col-md-4" >
           <div class="mapouter">
                <div class="gmap_canvas">
                    <iframe width="100%" height="100%" id="gmap_canvas" src="https://maps.google.com/maps?q=university%20of%20technology%20jamaica&t=&z=13&ie=UTF8&iwloc=&output=embed" frameborder="0" scrolling="no" marginheight="0" marginwidth="0"></iframe>
                </div>
            </div>
           <h5> Location </h5>
           <br><br>
        </div> 
    </div>
 </asp:Content>
