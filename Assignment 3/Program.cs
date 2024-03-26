using Assignment_3;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of vehicles
        Car car = new Car
        {
            Model = "X",
            Manufacturer = "Tesla",
            Year = 2023,
            RentalPrice = 100,
            Seats = 2,
            EngineType = "E",
            Transmission = "Auto",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "Truck 1",
            Manufacturer = "Ford",
            Year = 2022,
            RentalPrice = 200,
            Capacity = 4,
            TruckType = "Pickup",
            FourWheelDrive = true
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "Fatboy",
            Manufacturer = "Harley Davidson",
            Year = 2022,
            RentalPrice = 50,
            EngineCapacity = 1500,
            FuelType = "Gas",
            HasFairing = true
        };

        // Display details of vehicles
        car.DisplayDetails();
        truck.DisplayDetails();
        motorcycle.DisplayDetails();

        // Create a rental agency
        RentalAgency rentalAgency = new RentalAgency();
        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        // Rent a vehicle
        rentalAgency.RentVehicle(truck, 200);
        rentalAgency.RentVehicle(motorcycle, 50);

        // Display total revenue
        Console.WriteLine($"Total revenue: {rentalAgency.TotalRevenue}");
    }
}
