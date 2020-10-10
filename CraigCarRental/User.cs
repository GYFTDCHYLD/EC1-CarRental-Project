using System;

namespace CraigCarRental {

    public class User {
        private int UserID;
        private String Firstname;
        private String Lastname;
        private String Username;
        private String Password;
        private String Type;

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



        public void setId(int id) {
            this.UserID = id;
        }

        public int getId() {
            return UserID;
        }

        public void setFirstname(String Fname) {
            this.Firstname = Fname;
        }

        public String getFirstname() {
            return Firstname;
        }

        public void setLastname(String Lname) {
            this.Lastname = Lname;
        }

        public String getLastname() {
            return Lastname;
        }

        public void setUsername(String User) {
            this.Username = User;
        }

        public String getUsername() {
            return Username;
        }

        public void setPassword(String Pwd) {
            this.Password = Pwd;
        }

        public String getPassword() {
            return Password;
        }

        public void setType(String type) {
            this.Type = type;
        }

        public String getType() {
            return Type;
        }
    }
}