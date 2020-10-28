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

namespace CraigCarRental {

    public partial class Master : System.Web.UI.MasterPage {
      
        DataTable dt;
        int UserID = 1;
        DatabaseManager Database = new DatabaseManager();// creating an object of the database clsss in order to use it's method in this class

        public void Page_Load(object sender, EventArgs args) {

            cartLabel.Text = "";
            if (Session["CART"] != null) {
                dt = Database.CartQuery(UserID);
                //dt = (DataTable)Session["CART"];
                if(dt.Rows.Count > 0)
                    ShoppingCart.Text = dt.Rows.Count.ToString();
           }
        }

        public void openCart(object sender, EventArgs args){
            if (Session["LOGEDIN"] != null)
                if (dt.Rows.Count > 0)
                    Response.Redirect("CartItem.aspx");// redirect to cart id its not empty
                else
                    cartLabel.Text = "Cart is empty";
        }
    }
} 