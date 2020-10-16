using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CraigCarRental
{

    public partial class Invoice : System.Web.UI.Page {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs args) {
            if(Session["CHECKOUT"] != null) {
                dt = (DataTable)Session["CHECKOUT"];
                FillGrid();
                Session["CHECKOUT"] = null;
            }
            else {
                Response.Redirect("CartItem.aspx");// refresh page /redirect to itself
            }
            
        }

        public void FillGrid(){
            GridView1.DataSource = dt;
            GridView1.DataBind();
            cartTotal.Text = dt.Rows.Count.ToString();

           // calculateSum();
        }

        private void calculateSum() {
            double grandTotal = 0;
            foreach (DataRow dr in dt.Rows){
                grandTotal += Convert.ToDouble(dr["subTotal"]);
            }
            if (grandTotal > 0)
                cartTotal.Text = "GRAND TOTAL: $" + grandTotal;
            else
                Response.Redirect("CartItem.aspx");
        }

    }
}
