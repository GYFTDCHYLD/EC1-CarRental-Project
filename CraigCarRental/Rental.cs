using System;
namespace CraigCarRental{
    public class Rental{
        private Car car;
        private Customer customer;
        private int Days;

        public Rental() {

        }

        public Rental(Customer cus, Car cr, int days) {
            this.car = cr;
            this.customer = cus;
            this.Days = days;
        }


        public void setCustomer(Customer cus) {
            this.customer = cus;
        }

        public Customer getCustomer() {
            return customer;
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
