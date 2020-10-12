using System;
using System.Collections.Generic;

namespace CraigCarRental {
    public class CarDatabase {
        List<Car> Cars = new List<Car>();
        public CarDatabase() {
            Cars.Add(new Car("SKU1245", "BMW X6", 12000, "BMW", ""));
            Cars.Add(new Car("SKU1315", "BMW M3 Sedan", 9000, "BMW", ""));
            Cars.Add(new Car("SKU2265", "Mercedes - Benz E - Class", 11000, "Mercedes - Benz", ""));
            Cars.Add(new Car("SKU1705", "Mercedes - Benz GLC Coupe", 10500, "Mercedes - Benz", ""));
            Cars.Add(new Car("SKU4145", "Audi TT coupe", 11500, "Audi", ""));
            Cars.Add(new Car("SKU3261", "Audi A5 convertible", 9500, "Audi", ""));
        }

        public Car selectCar(String id) {

            foreach (var Car in Cars) {
                if (Car.ID.Equals(id))
                    return Car;
            }
            return null;     
        }

 
    }
}
