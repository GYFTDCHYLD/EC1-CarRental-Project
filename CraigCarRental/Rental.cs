using System;
namespace CraigCarRental{
    public class Rental{
        public Car car { get; set; }
        public User user { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public Rental() {

        }

        public Rental(User usr, Car cr, DateTime start, DateTime end) {
            this.car = cr;
            this.user = usr;
            this.startDate = start;
            this.endDate = end;
        }
    }
}
