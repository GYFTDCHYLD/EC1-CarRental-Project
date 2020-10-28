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
using System.Globalization;
using System.Threading;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace CraigCarRental{
    public partial class CartItem : System.Web.UI.Page {
        DataTable dt;
        Cart cart = new Cart();
        User UZR = new User();
        DatabaseManager Database = new DatabaseManager();// creating an object of the database clsss in order to use it's method in this class

        protected void Page_Load(object sender, EventArgs args) {
            if (Session["LOGEDIN"] != null)
                UZR = (User)Session["LOGEDIN"];

            if (Session["CHECKOUT"] == null) {
                dt = new DataTable();
                dt.Columns.Add("UserID");
                dt.Columns.Add("productID");
                dt.Columns.Add("productImage");
                dt.Columns.Add("productPrice");
                dt.Columns.Add("startDate");
                dt.Columns.Add("endDate");
                dt.Columns.Add("DaysRented");
                dt.Columns.Add("subTotal");
                Session["CHECKOUT"] = dt;
            }
            if (Session["CHECKOUT"] != null) {
                FillGrid();
            }
        }

        private void calculateSum() {
            double grandTotal = 0;
            foreach (DataRow dr in dt.Rows) {
                grandTotal += Convert.ToDouble(dr["subTotal"]);
            }
            if (grandTotal > 0)
                cartTotal.Text = "GRAND TOTAL: $" + grandTotal;
            else
                Response.Redirect("Products.aspx");//redirect to products if cart is empty
        }

        public void FillGrid() {
            dt = Database.CartQuery(UZR.UserID);
            Session["CHECKOUT"] = dt;
            GridView1.DataSource = dt;
            GridView1.DataBind();
            calculateSum();
        }


        public void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs args) {

            dt = Database.CartQuery(UZR.UserID);

            Database.DeleteRentalQuery(dt.Rows[args.RowIndex][1].ToString(), UZR.UserID, (DateTime)dt.Rows[args.RowIndex][4], (DateTime)dt.Rows[args.RowIndex][5]);

            dt.Rows[args.RowIndex].Delete();

            Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself
        }

        public void CheckoutItem(object sender, EventArgs args) {

            DateTime checkoutTime = DateTime.Now;
            string checkoutID = checkoutTime.ToString();
            checkoutID = checkoutID.Replace("AM", "");
            checkoutID = checkoutID.Replace("PM", "");
            checkoutID = checkoutID.Replace(" ", "");
            checkoutID = checkoutID.Replace("/", "");
            checkoutID = checkoutID.Replace(":", "");
            Checkout Checkout = new Checkout();
            int row = dt.Rows.Count-1;
            while (row >= 0){
                Checkout.checkouTime = checkoutTime;
                Checkout.OrderID = dt.Rows[row][0] + checkoutID.ToString();// user id plus timestamp to make unique order-id
                Checkout.CarID = dt.Rows[row][1].ToString();
                Checkout.Username = UZR.Username;
                Checkout.StartDate = (DateTime)dt.Rows[row][4];
                Checkout.EndDate = (DateTime)dt.Rows[row][5];
                Checkout.NumberOfDays = Int32.Parse(dt.Rows[row][6].ToString());
                Checkout.Subtotal = float.Parse(dt.Rows[row][7].ToString());
                Database.checkoutQuery(Checkout);

                Database.DeleteRentalQuery(dt.Rows[row][1].ToString(), UZR.UserID, (DateTime)dt.Rows[row][4], (DateTime)dt.Rows[row][5]);
                dt.Rows[row].Delete();
                row -= 1;
            }
            Session["CHECKOUT"] = Checkout.OrderID;
            Response.Redirect("Invoice.aspx");// refresh page /redirect to invoice
        }
    }
}