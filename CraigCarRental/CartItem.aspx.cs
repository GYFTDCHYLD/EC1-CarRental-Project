using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Collections.Generic;

namespace CraigCarRental{ 
    public partial class CartItem : System.Web.UI.Page {
        DataTable dt = new DataTable();
        DataRow dr;
        Cart cart = new Cart();
        String productName, productPrice, daysRented;
        protected void Page_Load(object sender, EventArgs args) {
            if (Session["cart"] != null) {
                cart = (Cart)Session["cart"];
                if (cart.getNumberOfItemInCart() >= 1) {
                    dt.Columns.Add("NAME");
                    dt.Columns.Add("PRICE");
                    dt.Columns.Add("DAYS RENTED");
                    Session["Data"] = dt;

                    Populate();
                }
            }
        }
        public void Populate() {
            DataTable dt = new DataTable();
            int i = 0;
            
            foreach (var Rental in cart.getCart()) {

                buttonInCart.Text = cart.getCart()[i].getCar().getName();
                productName = cart.getCart()[i].getCar().getName();
                productPrice = cart.getCart()[i].getCar().getPrice().ToString();
                daysRented = cart.getCart()[i].getDays().ToString();

                i++;

            }
        }
    }
}
