using System;
using System.Data;
using System.Web;
using System.Web.UI;

namespace CraigCarRental {

    public partial class OrderHistory : System.Web.UI.Page {
        DataTable dt;
        Cart cart = new Cart();
        User UZR = new User();
        DatabaseManager Database = new DatabaseManager();// creating an object of the database clsss in order to use it's method in this class

        protected void Page_Load(object sender, EventArgs args) {
            if (Session["ORDER_HISTORY"] != null)
                UZR = (User)Session["LOGEDIN"];

            if (Session["ORDER_HISTORY"] == null) {
                dt = new DataTable();
                dt.Columns.Add("productImage");
                dt.Columns.Add("productPrice");
                dt.Columns.Add("startDate");
                dt.Columns.Add("endDate");
                dt.Columns.Add("NumberOfDays");
                dt.Columns.Add("subTotal");
                Session["ORDER_HISTORY"] = dt;
            }
            if (Session["ORDER_HISTORY"] != null) {
                FillGrid();
            }
        }

        public void FillGrid() {
            dt = Database.OrderHistoryQuery(UZR.Username);
            Session["ORDER_HISTORY"] = dt;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

    }
}