using System;

namespace CraigCarRental {
    public class Car {
        public string productID { get; set; }
        public string productName { get; set; } 
        public float productPrice { get; set; }
        public string Category { get; set; }
        public string Description { get; set; } 

        public Car() {
            productID = "";
            productName = "";
            productPrice = (float)0.0;
            Category = ""; 
            Description = ""; 

        }

        public Car(string id, string name, float price, string category, string description) {
            this.productID = id;
            this.productName = name;
            this.productPrice = price;
            this.Category = category;
            this.Description = description;
        }

        public Car(Car copy) {
            this.productID = copy.productID;
            this.productName = copy.productName;
            this.productPrice = copy.productPrice;
            this.Category = copy.Category;
            this.Description = copy.Description;
        }
    }
}