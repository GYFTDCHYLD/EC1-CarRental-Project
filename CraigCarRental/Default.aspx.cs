using System;
using System.Web;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using Microsoft.VisualBasic;


namespace CraigCarRental {

    public partial class Default : System.Web.UI.Page {
        Cart cart;
        int days;
        readonly CarDatabase db = new CarDatabase();// initialize a database of cars

        public void Page_Load(object sender, EventArgs args) {
            if (Session["cart"] != null) {
                cart = (Cart)Session["cart"];
            }
            else {
                cart = new Cart();
                Session["cart"] = cart;
            }
        }

        public void ClickedDays(object sender, EventArgs args)  {
            ///days =  daysRented.Valve;
        }

        public void Clicked(object sender, EventArgs args){
            Button button = (Button)sender;
            string buttonId = button.ID;// get the "ID" from the pressed button
            
            
            Rental rentalData = new Rental(new Customer(), db.selectCar(buttonId), days);
            button.Text = rentalData.getCar().getName();

            if (Session["cart"] != null) {
                cart = (Cart)Session["cart"];
            }
            else {
                cart = new Cart();
                Session["cart"] = cart;
            }
            cart.AddToCart(rentalData);
            Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself




            /*
            if (Application["cart"] != null) { 
                cart = (Cart)Application["cart"]; // This is how we retrieve the value of the Application Variable
            }
            else {
                cart = new Cart();
                Application["cart"] = cart; // This sets the value of the Application Variable
            }
            */
        }
    }
}
