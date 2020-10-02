using System;
namespace CraigCarRental {
    public class Car {
        private String ID;
        private String Name;
        private float Price;
        private String Category;
        private String Description;

        public Car(){
            ID = "";
            Name = "";
            Price = (float)0.0;
            Category = "";
            Description = "";

        }

        public Car(String id, String name, float price, String category, String description) {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.Description = description;

        }


        public void setID(String id) {
            this.ID = id;
        }

        public String getID() {
            return ID;
        }

        public void setName(String name) {
            this.Name = name;
        }

        public String getName() {
            return Name;
        }

        public void setPrice(float price) {
            this.Price = price;
        }

        public float getPrice() {
            return Price;
        }

        public void setPCategory(String category) {
            this.Category = category;
        }

        public String getPCategory() {
            return Category;
        }

        public void setPassword(String description) {
            this.Description = description;
        }

        public String getDescription() {
            return Description;
        }
    }
}
