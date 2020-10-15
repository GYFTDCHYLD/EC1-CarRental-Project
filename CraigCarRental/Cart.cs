using System;
using System.Web;
using System.Web.UI;
using System.Collections.Generic;

namespace CraigCarRental{
    public class Cart {
        public int UserID { get; set; }
        public string productID { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int DaysRented { get; set; }
        public float subTotal { get; set; }
        public Boolean Checkout { get; set; } 
    }
}
