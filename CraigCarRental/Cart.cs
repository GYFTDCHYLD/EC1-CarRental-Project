using System;
using System.Web;
using System.Web.UI;
using System.Collections.Generic;

namespace CraigCarRental {
    public class Cart {

        List<Rental> Rentals = new List<Rental>();

        public Cart() {

        }

        public Cart(List<Rental> rentals) {
            this.Rentals = rentals;
        }

        public void AddToCart(Rental rental) {
            this.Rentals.Add(rental);
        }

        public void RemoveFromCart(String ID) {
            int i = 0;
            foreach (var Rental in Rentals){
                if (Rental.getCar().getID().Equals(ID)) {
                    Rentals.RemoveAt(i);
                    break;
                }
            i++;
            }
            
        }

        public List<CartItem> Items { get; internal set; }

        public List<Rental> getCart() {
            return Rentals;
        }

        public int getNumberOfItemInCart() {
            return Rentals.Count;
        }

        void DisplayAll() {
            foreach (var Rental in Rentals) {
                //Total += (Rental.getDays() * Rental.getCar().getPrice());
            }
        }
    }
}