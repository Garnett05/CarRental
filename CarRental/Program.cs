using System;
using System.Globalization;
using CarRental.Entities;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime pickup = DateTime.Parse(Console.ReadLine());
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime _return = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Rental rent = new Rental(carModel, pickup, _return);

            Console.WriteLine("INVOICE: ");
            Console.Write("Total payment: " + rent.RentalValue(pricePerHour, pricePerDay).ToString("F2"));

        }
    }
}
