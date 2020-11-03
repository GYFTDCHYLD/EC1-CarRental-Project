using System;
using System.Web;
using System.Web.UI;
using Org.BouncyCastle.Crypto.Generators;

namespace CraigCarRental{
    public partial class SignUp : System.Web.UI.Page{
        public void Page_Load(object sender, EventArgs args) {

        }
        public void createAccount(object sender, EventArgs args) {
            DatabaseManager DB = new DatabaseManager();
            if (!(Pasword.Text.Trim().Length > 7 && confirmPasword.Text.Trim().Length > 7)) {
                loginLabel.Text = "Passwords Must be atleast 8 Character";
            }
            else if (!(Pasword.Text.Equals(confirmPasword.Text)))
                loginLabel.Text = "Passwords don't match";
            else{
                //string passwordHash = BCrypt.Net.BCrypt.HashPassword("Pa$$w0rd");
                User user = new User(4, firstName.Text, lastName.Text, Username.Text, Pasword.Text.Trim(), "Customer");
   
                DB.signUp(user);
                Response.Redirect("Default.aspx");
            }
        }

    }
}
