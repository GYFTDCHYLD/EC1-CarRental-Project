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
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace CraigCarRental {

    public partial class Products : System.Web.UI.Page {
        DataTable dt;
        DataRow dr;
        Cart cart = new Cart();
        int days = 0;

        public void Page_Load(object sender, EventArgs args) {
            if (Session["CART"] == null) {
                dt = new DataTable();
                dt.Columns.Add("productID");
                dt.Columns.Add("productName");
                dt.Columns.Add("productPrice");
                dt.Columns.Add("DaysRented");
                dt.Columns.Add("subTotal");
                Session["CART"] = dt;
            }
        }


        public void getDays(object sender, EventArgs args) {
            int num = -1;
            if (int.TryParse(daysRented1.Text, out num))
                days = Convert.ToInt32(daysRented1.Text);
            else if (int.TryParse(daysRented2.Text, out num))
                days = Convert.ToInt32(daysRented2.Text);
            else if (int.TryParse(daysRented3.Text, out num))
                days = Convert.ToInt32(daysRented3.Text);
            else if (int.TryParse(daysRented4.Text, out num))
                days = Convert.ToInt32(daysRented4.Text);
            else if (int.TryParse(daysRented5.Text, out num))
                days = Convert.ToInt32(daysRented5.Text);
            else if (int.TryParse(daysRented6.Text, out num))
                days = Convert.ToInt32(daysRented6.Text);
        }

        public void Clicked(object sender, EventArgs args) {

            if (days > 0) {
                Button button = (Button)sender;
                string buttonId = button.ID;// get the "ID" from the pressed button
                DatabaseManager DB = new DatabaseManager();// creating an object of the database clsss in order to use it's method in this class
           
                Rental rentalData = new Rental(new User(1, "Craig", "Reid", "Admin"), DB.SelectCarQuery(buttonId), days);
                DB.RentalQuery(rentalData);

                dt = new DataTable();
                dt = (DataTable)Session["CART"];
                dr = dt.NewRow();
                dr["productID"] = rentalData.getCar().getID();
                dr["productName"] = rentalData.getCar().getName();
                dr["productPrice"] = rentalData.getCar().getPrice().ToString();
                dr["DaysRented"] = rentalData.getDays();
                dr["subTotal"] = (rentalData.getDays() * rentalData.getCar().getPrice());
                dt.Rows.Add(dr);
                Session["CART"] = dt;

                Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself

            }else {
                daysRented1.Text = "";
                daysRented2.Text = "";
                daysRented3.Text = "";
                daysRented4.Text = "";
                daysRented5.Text = "";
                daysRented6.Text = "";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Enter Number of day(s) before adding item to cart');", true);
            }
        }
    }
}