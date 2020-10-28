using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CraigCarRental {
    public partial class Default : System.Web.UI.Page {
        public void Page_Load(object sender, EventArgs args){
        
        }
        public void LoginUser(object sender, EventArgs args){
            DatabaseManager DB = new DatabaseManager();

            User UZR = DB.Login(Username.Text.Trim(), Pasword.Text.Trim());
            if (!UZR.Username.Equals("")){
                if (Session["LOGEDIN"] == null) {
                    Session["LOGEDIN"] = UZR;
                }
                if(UZR.UserType.Equals("Manager"))
                    Response.Redirect("AdminPanel.aspx");
                else
                    if (UZR.UserType.Equals("Customer"))
                        Response.Redirect("Home.aspx");
            }
            else
                loginLabel.Text = "Incorrect Username or Password";
        }
    }
}