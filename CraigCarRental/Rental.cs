using System;
namespace CraigCarRental{
    public class Rental{
        private Car car;
        private User user;
        private DateTime startDate;
        private DateTime endDate;

        public Rental() {

        }

        public Rental(User usr, Car cr, DateTime start, DateTime end) {
            this.car = cr;
            this.user = usr;
            this.startDate = start;
            this.endDate = end;
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

        public void setStartDate(DateTime start) {
            this.startDate = start; 
        }

        public DateTime getStartDate() {
            return startDate;
        }

        public void setVndDate(DateTime end) {
            this.endDate = end;
        }

        public DateTime getEndDate() {
            return endDate;
        }
    }
}
