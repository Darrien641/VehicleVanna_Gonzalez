using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleVannaClient
{
    public class Vehicle
    {
        public Vehicle(string make, string model, int year,
             double listPrice, string firstName, string lastName, string email, VehicleType type)
        {
            Make = make;
            Model = model;
            Year = year;
            ListPrice = listPrice;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            VehicleType_ = type;
        }
        public enum VehicleType
        {
            Car,
            SportsCar,
            Truck,
            Motorcycle,
            MotorHome,
            NoVehicleSelected
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double ListPrice { get; set; }
        public VehicleType VehicleType_ { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}

