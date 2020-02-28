using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CarRental.Entities
{
    class Rental
    {        
        public string CarModel { get; set; }
        public DateTime Pickup { get; set; }
        public DateTime Return { get; set; }

        public Rental()
        {
        }
        public Rental(string carModel, DateTime pickup, DateTime _return)
        {            
            CarModel = carModel;
            Pickup = pickup;
            Return = _return;
        }
        public double RentalValue(double pricePerHour, double pricePerDay)
        {
            TimeSpan diference = Return.Subtract(Pickup);

            if (diference.TotalHours <= 12)
            {
                double totalPrice = pricePerHour * Math.Ceiling(diference.TotalHours);
                if (totalPrice <= 100.00) {
                    return totalPrice + totalPrice * 0.2;
                }
                else
                {
                    return totalPrice + totalPrice * 0.15;
                }
            }
            else
            {
                double totalPrice = pricePerDay * Math.Ceiling(diference.TotalDays);
                if (totalPrice <= 100.00)
                {
                    return totalPrice + totalPrice * 0.2;
                }
                else
                {
                    return totalPrice + totalPrice * 0.15;
                }
            }
                        
        }
    }
}
