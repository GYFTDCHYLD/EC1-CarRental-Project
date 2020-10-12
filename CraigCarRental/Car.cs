using System;

namespace CraigCarRental
{
    public class Car
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Car()
        {
            ID = "";
            Name = "";
            Price = (float)0.0;
            Category = "";
            Description = "";

        }

        public Car(string id, string name, float price, string category, string description)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.Description = description;
        }

        public Car(Car copy)
        {
            this.ID = copy.ID;
            this.Name = copy.Name;
            this.Price = copy.Price;
            this.Category = copy.Category;
            this.Description = copy.Description;
        }
    }
}