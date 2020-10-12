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

    public partial class Default : System.Web.UI.Page {
        DataTable dt;
        DataRow dr;
        static int days = 0;
        DateTime StartDate, EndDate;

        public void Page_Load(object sender, EventArgs args) {
            if (Session["CART"] == null) {
                dt = new DataTable();
                dt.Columns.Add("productID");
                dt.Columns.Add("productName");
                dt.Columns.Add("productPrice");
                dt.Columns.Add("startDate");
                dt.Columns.Add("endDate");
                dt.Columns.Add("DaysRented");
                dt.Columns.Add("subTotal");
                Session["CART"] = dt;
            }
        }

       
        public void ProcessDate(object sender, EventArgs args) {
            if ((StartDate1.Text != "") && (EndDate1.Text != "")) {
                StartDate = DateTime.ParseExact(StartDate1.Text, "dd/MM/yyyy", null);
                EndDate = DateTime.ParseExact(EndDate1.Text, "dd/MM/yyyy", null);
            } else if ((StartDate2.Text != "") && (EndDate2.Text != "")) {
                StartDate = DateTime.ParseExact(StartDate2.Text, "dd/MM/yyyy", null);
                EndDate = DateTime.ParseExact(EndDate2.Text, "dd/MM/yyyy", null);
            }
            days = Int32.Parse((EndDate - StartDate).TotalDays.ToString());
        }

        public void Clicked(object sender, EventArgs args) {
            

            if (days > 0) {
                days = 0;
                Button button = (Button)sender;
                string buttonId = button.ID;// get the "ID" from the pressed button

                DatabaseManager DB = new DatabaseManager();// creating an object of the database clsss in order to use it's method in this class

                Rental rentalData = new Rental(new User(1, "Craig", "Reid", "Admin"), DB.SelectCarQuery(buttonId), StartDate, EndDate);
                DB.RentalQuery(rentalData);

                Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself

            }else {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Enter Start and End Date before adding item to cart');", true);
            }
        }
    }
}