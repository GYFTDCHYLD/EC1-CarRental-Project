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
        Car car = new Car();

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

        public void AdminGridUpdate(object sender, GridViewDeleteEventArgs args){
            id.Text = dt.Rows[args.RowIndex][0].ToString();
            name.Text = dt.Rows[args.RowIndex][1].ToString();
            price.Text = dt.Rows[args.RowIndex][2].ToString();
            category.Text = dt.Rows[args.RowIndex][3].ToString();
            description.Text = dt.Rows[args.RowIndex][4].ToString();
            image.Text = dt.Rows[args.RowIndex][5].ToString();
        }

        public void addData(object sender, EventArgs args) {
            try {
                car = new Car(id.Text, name.Text, Convert.ToInt32(price.Text), category.Text, description.Text);
                car.productImage = image.Text;
                Database.addUpdateCar(car, "ADD");
                Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself
            }
            catch (Exception) {


            }

        }

        public void updateData(object sender, EventArgs args) {
            try {
                car = new Car(id.Text, name.Text, Convert.ToInt32(price.Text), category.Text, description.Text);
                car.productImage = image.Text;
                Database.addUpdateCar(car, "UPDATE");
                Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself
            }
            catch (Exception) {


            }
        }

        public void deleteData(object sender, EventArgs args) {
            Database.DeleteCar(id.Text);
            Response.Redirect(Request.RawUrl.ToString());// refresh page /redirect to itself
        }
    }
}
