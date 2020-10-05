using System;
using System.Web;
using System.Web.UI;

namespace CraigCarRental {
    public class Global : HttpApplication {
        protected void Application_Start(){

        }
        /*
        void Session_Start() {
            Cart cart = new Cart();
        }*/

        void Session_Start(object sender, EventArgs e){
            Cart CART = new Cart();
        }
        

    }
}
