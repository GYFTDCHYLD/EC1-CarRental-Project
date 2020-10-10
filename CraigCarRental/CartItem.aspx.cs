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
        DataRow dr;
        Cart cart = new Cart();

        private string ConnectionString;

        protected void Page_Load(object sender, EventArgs args) {
            if (Session["CART"] == null) {
                dt = new DataTable();
                dt.Columns.Add("productID");
                dt.Columns.Add("productName");
                dt.Columns.Add("productPrice");
                dt.Columns.Add("DaysRented");
                dt.Columns.Add("subTotal");
                Session["CART"] = dt;
            }
            if (Session["CART"] != null) {
                FillGrid();
            }
        }

        private void calculateSum(){
            double grandTotal = 0;
            foreach (DataRow dr in dt.Rows){
                grandTotal += Convert.ToDouble(dr["subTotal"]);
            }
            if(grandTotal > 0)
                 cartTotal.Text = "GRAND TOTAL: $" + grandTotal;
            else
                Response.Redirect("Products.aspx");//redirect to products if cart is empty
        }

        public void FillGrid() {
            dt = new DataTable();
            dt = (DataTable)Session["CART"];
            GridView1.DataSource = dt;
            GridView1.DataBind();
            calculateSum();
        }


        public void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs args ) {

            ConnectionString = @"Server=localhost;Database=AppDatabase;Uid=root;Pwd=EnterpriseComputing1;";

            dt = new DataTable();
            dt = (DataTable)Session["CART"];

            DeleteRentalQuery(dt.Rows[args.RowIndex][0].ToString());

            dt.Rows[args.RowIndex].Delete();
            Session["CART"] = dt;

            Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself
        }

        public void DeleteRentalQuery(string ID) {

            try {
                using (MySqlConnection sqlConnection = new MySqlConnection(ConnectionString)) {
                    sqlConnection.Open();
                    MySqlCommand sqlCmd = new MySqlCommand("RemoveRental", sqlConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("_CarID", ID);
                    sqlCmd.ExecuteNonQuery();
                }

            }
            catch (Exception e) {

            }
        }
    }
}