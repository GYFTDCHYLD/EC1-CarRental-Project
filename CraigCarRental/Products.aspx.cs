using System;
using System.Web;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Management.Instrumentation;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Web.UI.HtmlControls;

namespace CraigCarRental {

    public partial class Products : System.Web.UI.Page {
        DataTable dt;
        DataRow dr;
        Cart cart = new Cart();
        static int days = 0;
        DateTime StartDate, EndDate;

        public void Page_Load(object sender, EventArgs args) {
            if (!IsPostBack) { 
                DatabaseManager db = new DatabaseManager();
                PRODUCTS.DataSource = db.ProductQuery();
                PRODUCTS.DataBind();
            }
        }


        public void PRODUCTS_ItemCommand(object source, DataListCommandEventArgs arg) {
            if (arg.CommandName.Equals("addToCart")) {

                string start = Request.Form["StartDate1"].Trim(new Char[] { ',' });
                string end = Request.Form["EndDate1"].Trim(new Char[] { ',' });

                try {
                    StartDate = DateTime.ParseExact(start, "dd/MM/yyyy", null);
                    EndDate = DateTime.ParseExact(end, "dd/MM/yyyy", null);
                    days = Int32.Parse((EndDate - StartDate).TotalDays.ToString());
                }
                catch(Exception) {
                    days = 0;
                }
            }

            if (days > 0) {
                string buttonId = arg.CommandArgument.ToString();// get the "ID" from the pressed button
                DatabaseManager DB = new DatabaseManager();// creating an object of the database clsss in order to use it's method in this class

                Rental rentalData = new Rental(new User(1, "Craig", "Reid", "Admin"), DB.SelectCarQuery(buttonId), StartDate, EndDate);
                DB.RentalQuery(rentalData);

                Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself
            }
            else {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Enter Start and End Date before adding item to cart');", true);
            }
        }
    }
}