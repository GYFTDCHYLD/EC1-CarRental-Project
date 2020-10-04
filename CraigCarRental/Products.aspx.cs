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
  
    public partial class Products : System.Web.UI.Page {
        DataTable dt;
        DataRow dr;
        Cart cart = new Cart();
        readonly CarDatabase db = new CarDatabase();// initialize a database of car

        public void Page_Load(object sender, EventArgs args) {
            if (Session["Data"] == null) {
                dt = new DataTable();
                dt.Columns.Add("productID");
                dt.Columns.Add("productName");
                dt.Columns.Add("productPrice");
                dt.Columns.Add("DaysRented");
                dt.Columns.Add("subTotal");
                Session["Data"] = dt;
            }

            //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('script running in pag eload');", true);
        }

        public void Clicked(object sender, EventArgs args) {
            Button button = (Button)sender;
            string buttonId = button.ID;// get the "ID" from the pressed button
            


            int days = 10;
            Rental rentalData = new Rental(new Customer(), db.selectCar(buttonId), days);  

            if (Session["cart"] != null) {
                cart = (Cart)Session["cart"];
            }
            cart.AddToCart(rentalData);
            Session["cart"] = cart;

            dt = new DataTable();
            dt = (DataTable)Session["Data"];
            dr = dt.NewRow();
            dr["productID"] = rentalData.getCar().getID();
            dr["productName"] = rentalData.getCar().getName();
            dr["productPrice"] = "$" + rentalData.getCar().getPrice().ToString();
            dr["DaysRented"] = rentalData.getDays();
            dr["subTotal"] = "$" + (rentalData.getDays() * rentalData.getCar().getPrice());
            dt.Rows.Add(dr);
            Session["Data"] = dt;
           


            Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself

            //button.Text = cart.getCart()[0].getCar().getName();




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