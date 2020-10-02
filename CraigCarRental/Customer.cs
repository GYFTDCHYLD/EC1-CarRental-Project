using System;
namespace CraigCarRental {
    
    public class Customer{
        private int UserID;
        private String Firstname;
        private String Lastname;
        private String Username;
        private String Password;

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

    }
}
