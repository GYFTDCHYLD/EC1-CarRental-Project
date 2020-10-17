﻿using System;
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
                    car = new Car(Convert.ToString(dr["productID"]), Convert.ToString(dr["productName"]), (float)(dr["productPrice"]), Convert.ToString(dr["Category"]), Convert.ToString(dr["Description"]));
                }
                dr.Close();
                return car;

            }catch (Exception) {

            }
        return car;
        }

        public void RentalQuery(Rental rentalData) {
        //string ConnectionString = @"server=127.0.0.1;" + @"uid=root;" + @"pwd=EnterpriseComputing1;" + @"database=AppDatabase;";

            try {
                using (MySqlConnection sqlConnection = new MySqlConnection(ConnectionString)) {
                    sqlConnection.Open();
                    MySqlCommand sqlCmd = new MySqlCommand("AddToCart", sqlConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("_CarID", rentalData.car.productID);
                    sqlCmd.Parameters.AddWithValue("_UserID", rentalData.user.UserID);
                    //sqlCmd.Parameters.AddWithValue("_StartDate", DateTime.Today);
                    // sqlCmd.Parameters.AddWithValue("_EndDate", DateTime.Today.AddDays(rentalData.getDays()));
                    sqlCmd.Parameters.AddWithValue("_StartDate", rentalData.startDate);
                    sqlCmd.Parameters.AddWithValue("_EndDate", rentalData.endDate);
                    sqlCmd.ExecuteNonQuery();
                }

            } catch (Exception) {

            }
        }


        public void DeleteRentalQuery(string carID, int userID, DateTime sdate, DateTime edate) {
            try {
                using (MySqlConnection sqlConnection = new MySqlConnection(ConnectionString)) {
                    sqlConnection.Open();
                    MySqlCommand sqlCmd = new MySqlCommand("RemoveFromCart", sqlConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("_CarID", carID);
                    sqlCmd.Parameters.AddWithValue("_UserID", userID);
                    sqlCmd.Parameters.AddWithValue("_StartDate", sdate);
                    sqlCmd.Parameters.AddWithValue("_EndDate", edate);
                    sqlCmd.ExecuteNonQuery();
                }

            } catch (Exception) {

            }
        }

       
        public DataTable CartQuery(int ID) { 
            DataTable table = new DataTable();
            try {
                using (MySqlConnection sqlConnection = new MySqlConnection(ConnectionString)) {
                    sqlConnection.Open();
                    MySqlDataAdapter  sqlData = new MySqlDataAdapter("RetrieveCart", sqlConnection);
                    sqlData.SelectCommand.Parameters.AddWithValue("_UserID", ID);
                    sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                   
                    sqlData.Fill(table);
                }

            } catch (Exception) {

            }
         return table;
        }

        public void checkoutQuery(Checkout Checkout) {
            try {
                using (MySqlConnection sqlConnection = new MySqlConnection(ConnectionString)) {
                    sqlConnection.Open();
                    MySqlCommand sqlCmd = new MySqlCommand("processOrder", sqlConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("_OrderID", Checkout.OrderID);
                    sqlCmd.Parameters.AddWithValue("_CarID", Checkout.CarID);
                    sqlCmd.Parameters.AddWithValue("_Username", Checkout.Username);
                    sqlCmd.Parameters.AddWithValue("_StartDate", Checkout.StartDate);
                    sqlCmd.Parameters.AddWithValue("_EndDate", Checkout.EndDate);
                    sqlCmd.Parameters.AddWithValue("_NumberOfDays", Checkout.NumberOfDays);
                    sqlCmd.Parameters.AddWithValue("_orderDate", Checkout.checkouTime);
                    sqlCmd.ExecuteNonQuery();
                    sqlConnection.Close(); 
                }
            }
            catch (Exception) {

            }
        }



        public DataSet ProductQuery(){// retrieve product from tatabace to be displayed on product page
            DataSet dataSet = new DataSet();
            try {
                using (MySqlConnection sqlConnection = new MySqlConnection(ConnectionString)) {
                    sqlConnection.Open();
                    MySqlDataAdapter sqlData = new MySqlDataAdapter("displayCar", sqlConnection);
                    sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                    
                    sqlData.Fill(dataSet);
                    //DataList1.DataSource = dataSet;
                   // DataList1.DataBind();
                    sqlConnection.Close();
                }
            }
            catch (Exception){

            }
            return dataSet;
        }
    }
}