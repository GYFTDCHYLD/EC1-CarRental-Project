using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CraigCarRental {
    public partial class AdminPanel : System.Web.UI.Page {
        DataTable dt;
        Cart cart = new Cart();
        User UZR = new User();
        
        DatabaseManager Database = new DatabaseManager();// creating an object of the database clsss in order to use it's method in this class

        protected void Page_Load(object sender, EventArgs args) {
            if (Session["LOGEDIN"] != null) {
                UZR = (User)Session["LOGEDIN"];
            }

            if (!UZR.UserType.Equals("Manager"))
                Response.Redirect("Default.aspx");

            if (Session["DATA"] == null) {
                dt = new DataTable();
                dt.Columns.Add("productID");
                dt.Columns.Add("productName");
                dt.Columns.Add("productPrice");
                dt.Columns.Add("Category");
                dt.Columns.Add("Description");
                dt.Columns.Add("productImage");
                Session["DATA"] = dt;
            }
            if (Session["DATA"] != null) {
                FillGrid();
            }
        }

        public void FillGrid() {
            dt = Database.AdminQuery();
            Session["DATA"] = dt;
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }


        public void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs args){

            Database.DeleteCar(dt.Rows[args.RowIndex][0].ToString());

            dt.Rows[args.RowIndex].Delete();

            Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself
        }

    }
}
