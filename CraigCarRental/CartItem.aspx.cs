using System;
using System.Web;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Collections;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Management.Instrumentation;

namespace CraigCarRental{ 
    public partial class CartItem : System.Web.UI.Page {
        DataTable dt = new DataTable();
        DataRow dr;
        Cart cart = new Cart();
        float Total;
        String productName, productPrice, daysRented;
        protected void Page_Load(object sender, EventArgs args) {
            
            if (Session["cart"] != null) {
                cart = (Cart)Session["cart"];
                if (cart.getNumberOfItemInCart() >= 1) {
                

                    Populate();
                }
            }
        }

        public void Remove(object sender, EventArgs args) {
            Button button = (Button)sender;
            string buttonId = button.ID;// get the "ID" from the pressed button
            cart.RemoveFromCart(buttonId);
            Session["cart"] = cart;
            Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself
        }

        public void Populate() {
            DataTable dt = new DataTable();
            int i = 0;
            
            foreach (var Rental in cart.getCart()) {
                Total += (Rental.getDays() * Rental.getCar().getPrice());
                buttonInCart.Text = Total.ToString();
                productName = cart.getCart()[i].getCar().getName();
                productPrice = cart.getCart()[i].getCar().getPrice().ToString();
                daysRented = cart.getCart()[i].getDays().ToString();

                i++;

            }
        }

       
    }
}
