using System;
namespace CraigCarRental{
    public class Rental{
        public Car car { get; set; }
        public Customer customer { get; set; }
        public int Days { get; set; }

        public Rental() {

        }

        public Rental(Customer cus, Car cr, int days) {
            this.car = cr;
            this.customer = cus;
            this.Days = days;
        }
    }
}
