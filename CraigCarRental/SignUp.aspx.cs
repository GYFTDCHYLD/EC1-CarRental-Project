using System;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using Org.BouncyCastle.Crypto.Generators;

namespace CraigCarRental{
    public partial class SignUp : System.Web.UI.Page{
        public void Page_Load(object sender, EventArgs args) {

        }
        public void createAccount(object sender, EventArgs args) {
            DatabaseManager DB = new DatabaseManager();
            if (!(Pasword.Text.Trim().Length >= 8)) {
                loginLabel.Text = "Passwords Must be atleast 8 Character";
            }
            else {

                bool isDigitPresent = Pasword.Text.Any(c => char.IsDigit(c));
                bool isLetterPresent = Pasword.Text.Any(c => char.IsLetter(c));
                bool isUpperCaseLetterPresent = Pasword.Text.Any(c => char.IsUpper(c));
                bool isLowerCaseLetterPresent = Pasword.Text.Any(c => char.IsLower(c));
                loginLabel.Text = "";
                if (isDigitPresent && isLetterPresent && isUpperCaseLetterPresent && isLowerCaseLetterPresent && (Pasword.Text.Equals(confirmPasword.Text))){
                        //string passwordHash = BCrypt.Net.BCrypt.HashPassword("Pa$$w0rd");
                        User user = new User(1, firstName.Text.Trim(), lastName.Text.Trim(), Username.Text.Trim(), Pasword.Text.Trim(), "Customer");

                        DB.signUp(user);
                        loginLabel.Text += "Account Created ";
                        Thread.Sleep(2000);
                        Response.Redirect("Default.aspx");

                }
                else {
                    if (!isDigitPresent) {
                        loginLabel.Text += "Passwords Must contain atleast 1 number ";
                    }
                    if (isLetterPresent) {
                        if (!isUpperCaseLetterPresent) {
                            loginLabel.Text += "Passwords Must contain atleast 1 UpperCase letter ";
                        }
                        if (!isLowerCaseLetterPresent) {
                            loginLabel.Text += "Passwords Must contain atleast 1 LowerCase letter ";
                        }
                    }
                    else {
                        loginLabel.Text += "Passwords Must contain atleast 2 Letter ";
                    }
                    if (!(Pasword.Text.Equals(confirmPasword.Text))) {
                        loginLabel.Text += "Passwords don't match ";
                    }
                }
            } 
        }
    }
}
