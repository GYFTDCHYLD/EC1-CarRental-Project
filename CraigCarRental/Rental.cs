using System;
namespace CraigCarRental{
    public class Rental{
        private Car car;
        private User user;
        private int Days;

        public Rental() {

        }

        public Rental(User usr, Car cr, int days) {
            this.car = cr;
            this.user = usr;
            this.Days = days;
        }


        public void setCustomer(User usr) {
            this.user = usr;
        }

        public User getCustomer() {
            return user;
        }

        public void setCar(Car cr) {
            this.car = cr;
        }

        public Car getCar() {
            return car;
        }

        public void setDays(int days) {
            this.Days = days; 
        }

        public int getDays() {
            return Days;
        }
    }
}
