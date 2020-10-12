using System;

namespace CraigCarRental {
    public class Car {
        public string CarID { get; set; }
        public string CarName { get; set; } 
        public float Price { get; set; }
        public string Category { get; set; }
        public string Discription { get; set; } 

        public Car() {
            CarID = "";
            CarName = "";
            Price = (float)0.0;
            Category = "";
            Discription = "";

        }

        public Car(string id, string name, float price, string category, string description) {
            this.CarID = id;
            this.CarName = name;
            this.Price = price;
            this.Category = category;
            this.Discription = description;
        }

        public Car(Car copy) {
            this.CarID = copy.CarID;
            this.CarName = copy.CarName;
            this.Price = copy.Price;
            this.Category = copy.Category;
            this.Discription = copy.Discription;
        }
    }
}