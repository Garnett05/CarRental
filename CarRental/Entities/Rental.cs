using System;
using System.Collections.Generic;
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


    }
}
