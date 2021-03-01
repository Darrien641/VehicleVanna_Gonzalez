using System;
using System.Threading.Tasks;
namespace VehicleVannaClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Menu menu = new Menu();
            menu.AddMenuItems();
            Vehicle vehicle;
            decimal ListPrice;
            string FirstName;
            string LastName;
            string Make;
            string Model;
            int Year;
            string Type;
            string Email;

            Console.WriteLine(menu.MenuItems[0]);
            Console.WriteLine(menu.MenuItems[1]);
            FirstName = Console.ReadLine();
            Console.WriteLine(menu.MenuItems[2]);
            LastName = Console.ReadLine();
            Console.WriteLine(menu.MenuItems[3]);
            Email = Console.ReadLine();
            Console.WriteLine(menu.MenuItems[4]);
            Type = Console.ReadLine();
            Console.WriteLine(menu.MenuItems[5]);
            Make = Console.ReadLine();
            Console.WriteLine(menu.MenuItems[6]);
            Model = Console.ReadLine();
            Console.WriteLine(menu.MenuItems[7]);
            Year = int.Parse(Console.ReadLine());

            Vehicle.VehicleType VehicleEnum = VehicleData.GetVehicleType(Type);
            ListPrice = VehicleData.GetPrice(VehicleEnum);
            vehicle = new Vehicle(Make, Model, Convert.ToInt32(Year), ListPrice, FirstName, LastName, Email, VehicleEnum);
            //Console.WriteLine(VehicleEnum.ToString());
            await HttpTrigger.HttpResponse(vehicle);

        }
    }
}
