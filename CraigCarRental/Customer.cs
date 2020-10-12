using System;
namespace CraigCarRental {
    
    public class Customer{
        public int UserID { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        public Customer(){
            UserID = 0;
            Firstname = "";
            Lastname = "";
            Username = "";
            Password = "";
        }

        public Customer(int ID, String Fname, String Lname, String User, String Pwd){
            this.UserID = ID;
            this.Firstname = Fname;
            this.Lastname = Lname;
            this.Username = User;
            this.Password = Pwd;
        }
    }
}
