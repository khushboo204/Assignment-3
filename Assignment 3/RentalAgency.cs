using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class RentalAgency
    {
        private List<Vehicle> Fleet { get; set; }
        public decimal TotalRevenue { get; private set; }

        public RentalAgency()
        {
            Fleet = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Fleet.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            Fleet.Remove(vehicle);
        }

        public void RentVehicle(Vehicle vehicle, decimal rentalPrice)
        {
            if (Fleet.Contains(vehicle))
            {
                RemoveVehicle(vehicle);
                TotalRevenue += rentalPrice;
                Console.WriteLine($"Vehicle rented: {vehicle.Model}");
            }
            else
            {
                Console.WriteLine("Vehicle not available for rent.");
            }
        }
    }
}
