using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleVannaClient
{
    class Menu
    {
        public List<string> MenuItems = new List<string>();
        public void AddMenuItems()
        {
            MenuItems.Add("To purchase a Vehicle you must enter some information.");
            MenuItems.Add("Enter Your First Name: ");
            MenuItems.Add("Enter your Last Name: ");
            MenuItems.Add("Enter your Email: ");
            MenuItems.Add("Enter The vehicle type your are looking for: ");
            MenuItems.Add("Enter the Make of the car: ");
            MenuItems.Add("Enter the Model of the car: ");
            MenuItems.Add("Enter the Year of the car: ");
        }
    }
}
