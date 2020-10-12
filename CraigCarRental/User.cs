using System;

namespace CraigCarRental {

    public class User {
        public int UserID { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Type { get; set; }

        public User() {
            UserID = 0;
            Firstname = "";
            Lastname = "";
            Username = "";
            Password = "";
            Type = "";
        }


        public User(int ID, String Fname, String Lname, String type) {
            this.UserID = ID;
            this.Firstname = Fname;
            this.Lastname = Lname;
            this.Type = type;
        }

        public User(int ID, String Fname, String Lname, String User, String Pwd, String type){
            this.UserID = ID;
            this.Firstname = Fname;
            this.Lastname = Lname;
            this.Username = User;
            this.Password = Pwd;
            this.Type = type;
        }
    }
}