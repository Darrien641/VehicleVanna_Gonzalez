using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleVannaClient
{
    class VehicleData
    {

        public static int GetPrice(Vehicle.VehicleType type)
        {
            if (type == Vehicle.VehicleType.Car)
            {
                return 35000;
            }
            else if (type == Vehicle.VehicleType.Motorcycle)
            {
                return 15000;
            }
            else if (type == Vehicle.VehicleType.MotorHome)
            {
                return 90000;
            }
            else if (type == Vehicle.VehicleType.SportsCar)
            {
                return 80000;
            }
            else if (type == Vehicle.VehicleType.Truck)
            {
                return 60000;
            }
            else
            {
                return 0;
            }
        }
        public static Vehicle.VehicleType GetVehicleType(string type)
        {

            if (type.ToLower() == "car")
            {

                return Vehicle.VehicleType.Car;
            }
            else if (type.ToLower() == "sports car")
            {

                return Vehicle.VehicleType.SportsCar;
            }
            else if (type.ToLower() == "truck")
            {

                return Vehicle.VehicleType.Truck;
            }
            else if (type.ToLower() == "motorcycle")
            {

                return Vehicle.VehicleType.Motorcycle;
            }
            else if (type.ToLower() == "motorhome")
            {

                return Vehicle.VehicleType.MotorHome;
            }
            else
            {
                return Vehicle.VehicleType.NoVehicleSelected;
            }
        }
    }
}
