using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CraigCarRental {
    public partial class AdminPanel : System.Web.UI.Page {
        DataTable Cdt, Udt; 
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

            if (Session["CDATA"] == null) {
                Cdt = new DataTable();
                Cdt.Columns.Add("productID");
                Cdt.Columns.Add("productName");
                Cdt.Columns.Add("productPrice");
                Cdt.Columns.Add("Category");
                Cdt.Columns.Add("Description");
                Cdt.Columns.Add("productImage");
                Session["CDATA"] = Cdt;
            }

            if (Session["UDATA"] == null) {
                Udt = new DataTable();
                Udt.Columns.Add("UserID");
                Udt.Columns.Add("Firstname");
                Udt.Columns.Add("Lastname");
                Udt.Columns.Add("Username");
                Udt.Columns.Add("Passwrd");
                Udt.Columns.Add("UserType");
                Session["UDATA"] = Udt; 
            }
            if (Session["CDATA"] != null) {
                FillGridC();
            }
            if (Session["UDATA"] != null) {
                FillGridU();
            }
        }

        public void FillGridC() {
            Cdt = Database.AdminQuery();
            Session["CDATA"] = Cdt;
            ProductGrid.DataSource = Cdt;
            ProductGrid.DataBind();
        }

        public void FillGridU() {
            Cdt = Database.UsersQuery();
            Session["UDATA"] = Cdt;
            UserGrid.DataSource = Cdt;
            UserGrid.DataBind();
        }

        public void AdminGridUpdate(object sender, GridViewDeleteEventArgs args){
            id.Text = Cdt.Rows[args.RowIndex][0].ToString();
            name.Text = Cdt.Rows[args.RowIndex][1].ToString();
            price.Text = Cdt.Rows[args.RowIndex][2].ToString();
            category.Text = Cdt.Rows[args.RowIndex][3].ToString();
            description.Text = Cdt.Rows[args.RowIndex][4].ToString();
            image.Text = Cdt.Rows[args.RowIndex][5].ToString();
        }

        
        public void UserGridUpdate(object sender, GridViewDeleteEventArgs args){
            id.Text = Cdt.Rows[args.RowIndex][0].ToString();
            name.Text = Cdt.Rows[args.RowIndex][1].ToString();
            price.Text = Cdt.Rows[args.RowIndex][2].ToString();
            category.Text = Cdt.Rows[args.RowIndex][3].ToString();
            description.Text = Cdt.Rows[args.RowIndex][4].ToString();
            image.Text = Cdt.Rows[args.RowIndex][5].ToString();
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
