using System;
using System.Web;
using System.Web.UI;
using MySql.Data.MySqlClient;

namespace CraigCarRental
{
    public class Global : HttpApplication
    {
        static MySqlConnection con;

        protected void Application_Start()
        {

        }
        /*
        void Session_Start() {
            Cart cart = new Cart();
        }*/

        void Session_Start(object sender, EventArgs e)
        {
            Cart CART = new Cart();

        }

        public static void Connect(string user, string password)
        {
            con = new MySqlConnection();

            try
            {
                con.ConnectionString = "server = localhost; User Id = " + user + "; " + "Persist Security Info = True; database = hello; Password = " + password;
                con.Open();
                Console.WriteLine("Succesfully connected!");


            }
            catch (Exception e)
            {
                Console.WriteLine("Not Successful! due to " + e.ToString());
            }
        }

        public static void main(string[] args)
        {
            Connect("root", "EnterpriseComputing1");
        }


    }
}
