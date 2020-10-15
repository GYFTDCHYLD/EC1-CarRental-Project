using System;
namespace CraigCarRental {
    public class Checkout {
        public DateTime checkouTime { get; set; }
        public string OrderID { get; set; }
        public string CarID { get; set; }
        public string Username { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfDays { get; set; }
        public float Subtotal { get; set; }

        public Checkout(){

        }

        public Checkout(DateTime check, string OID, string CID, string User, DateTime Start, DateTime End, int Days, float Sub){
            this.checkouTime = check;
            this.OrderID = OID;
            this.CarID = CarID;
            this.Username = User;
            this.StartDate = Start;
            this.EndDate = End;
            this.NumberOfDays = Days;
            this.Subtotal = Sub;
        }
    }
}
