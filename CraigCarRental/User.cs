using System;

namespace CraigCarRental {

    public class User {
        public int UserID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public User() {
            UserID = 0;
            Firstname = "";
            Lastname = "";
            Username = "";
            Password = "";
            UserType = "";
        }


        public User(int ID, string Fname, string Lname, string type) {
            this.UserID = ID;
            this.Firstname = Fname;
            this.Lastname = Lname;
            this.UserType = type;
        }

        public User(string Fname, string Lname, string User, string Pwd, string type) {
            this.Firstname = Fname;
            this.Lastname = Lname;
            this.Username = User;
            this.Password = Pwd;
            this.UserType = type;
        }

        public User(int ID, string Fname, string Lname, string User, string Pwd, string type){
            this.UserID = ID;
            this.Firstname = Fname;
            this.Lastname = Lname;
            this.Username = User;
            this.Password = Pwd;
            this.UserType = type; 
        }
    }
}