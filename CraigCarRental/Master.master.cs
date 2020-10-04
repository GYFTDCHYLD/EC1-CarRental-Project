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

namespace CraigCarRental {


    public partial class Master : System.Web.UI.MasterPage {
        public void Page_Load(object sender, EventArgs args) {
            if (Session["cart"] != null) {
                Cart cart = (Cart)Session["cart"];
                if(cart.getNumberOfItemInCart() >= 1)
                    ShoppingCart.Text = cart.getNumberOfItemInCart().ToString();
            }
        }
        public void OpenCart(object sender, EventArgs args) {

        }
    }
} 