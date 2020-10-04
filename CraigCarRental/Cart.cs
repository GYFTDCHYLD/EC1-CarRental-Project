using System;
using System.Web;
using System.Web.UI;
using System.Collections.Generic;

namespace CraigCarRental {
    public class Cart {

        List<Rental> Rentals = new List<Rental>();

        public Cart(){

        }

        public Cart(List<Rental> rentals){
            this.Rentals = rentals;
        }

        public void AddToCart(Rental rental){
            this.Rentals.Add(rental);
        }

        public void RemoveFromCart(Rental rental) {
            this.Rentals.Remove(rental);
        }

        public List<CartItem> Items { get; internal set; }

        public List<Rental> getCart() {  
            return Rentals;
        }

        public int getNumberOfItemInCart(){ 
            return Rentals.Count;
        }

        void DisplayAll() {
            foreach (var Rental in Rentals) {
                Console.WriteLine("Rental: [{0}:{1}] ,[{2}:{3},{4}]", Rental.getCustomer().getId() , Rental.getCustomer().getUsername(), Rental.getCar().getID(), Rental.getCar().getName(), Rental.getDays());
            }
        }
    }
}