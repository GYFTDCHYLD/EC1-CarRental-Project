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
        DataTable dt;
        DataRow dr;
        Cart cart = new Cart();
        float Total;
        String productName, productPrice, daysRented;
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

        public void FillGrid() {
            dt = new DataTable();
            dt = (DataTable)Session["CART"];
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }


        public void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs args ) {
            dt = new DataTable();
            dt = (DataTable)Session["CART"];
            dt.Rows[args.RowIndex].Delete();
            Session["CART"] = dt;
            FillGrid();
            Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself
        }
    }
}
