using System;
using System.Web;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Collections;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Management.Instrumentation;
using MySql.Data.MySqlClient;
using System.ComponentModel;


namespace CraigCarRental {

    public class DatabaseManager {

        private string ConnectionString = @"Server=localhost;Database=AppDatabase;Uid=root;Pwd=EnterpriseComputing1;";

        public DatabaseManager(){

        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public Car SelectCarQuery(String ID) {

            Car car = new Car();
            try {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                MySqlCommand command = new MySqlCommand("SelectCar", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_CarID", MySqlDbType.String).Value = ID;
                connection.Open();
                MySqlDataReader dr = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read()) {
                    car = new Car(Convert.ToString(dr["CarID"]), Convert.ToString(dr["CarName"]), (float)(dr["Price"]), Convert.ToString(dr["Category"]), Convert.ToString(dr["Discription"]));
                }
                dr.Close();
                return car;

            }catch (Exception e) {

            }

        return car;
        }

        public void RentalQuery(Rental rentalData) {
        //string ConnectionString = @"server=127.0.0.1;" + @"uid=root;" + @"pwd=EnterpriseComputing1;" + @"database=AppDatabase;";

            try {
                using (MySqlConnection sqlConnection = new MySqlConnection(ConnectionString)) {
                    sqlConnection.Open();
                    MySqlCommand sqlCmd = new MySqlCommand("AddRental", sqlConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("_CarID", rentalData.getCar().getID());
                    sqlCmd.Parameters.AddWithValue("_UserID", rentalData.getCustomer().getId());
                    sqlCmd.Parameters.AddWithValue("_StartDate", DateTime.Today);
                    sqlCmd.Parameters.AddWithValue("_EndDate", DateTime.Today.AddDays(rentalData.getDays()));
                    sqlCmd.Parameters.AddWithValue("_Checkout", false);
                    sqlCmd.ExecuteNonQuery();
                }

            } catch (Exception e) {

            }
        }


        public void DeleteRentalQuery(string ID) {
            try {
                using (MySqlConnection sqlConnection = new MySqlConnection(ConnectionString)) {
                    sqlConnection.Open();
                    MySqlCommand sqlCmd = new MySqlCommand("RemoveRental", sqlConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("_CarID", ID);
                    sqlCmd.ExecuteNonQuery();
                }

            } catch (Exception e) {

            }
        }
    }
}
