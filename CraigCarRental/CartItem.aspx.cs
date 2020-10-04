﻿using System;
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
            if (Session["Data"] == null) {
                dt = new DataTable();
                dt.Columns.Add("productID");
                dt.Columns.Add("productName");
                dt.Columns.Add("productPrice");
                dt.Columns.Add("DaysRented");
                dt.Columns.Add("subTotal");
                Session["Data"] = dt;
            }
            if (Session["cart"] != null) {
                FillGrid();
            }
        }

        public void FillGrid() {
            dt = new DataTable();
            dt = (DataTable)Session["Data"];
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }



        public void Remove(object sender, EventArgs args) {
            Button button = (Button)sender;
            string buttonId = button.ID;// get the "ID" from the pressed button
            cart.RemoveFromCart();
            Session["Data"] = cart;
            Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself
        }

        public void Remove() {
            cart.RemoveFromCart();
            Session["Data"] = cart;
            Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself
        }


        public void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs args ) {
            dt = new DataTable();
            dt = (DataTable)Session["Data"];
            dt.Rows[args.RowIndex].Delete();
            Session["Data"] = dt;
            FillGrid();
        }
    }
}
