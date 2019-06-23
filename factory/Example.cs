using System;

namespace DesignPatterns
{
    class MainOfFactory
    {
        static void Example(string[] args)
        {
            Console.WriteLine(VehicleFactory.CreateVehicle("Car").ToString());
            Console.WriteLine(VehicleFactory.CreateVehicle("Tank").ToString());
            Console.WriteLine(VehicleFactory.CreateVehicle("Bike") == null);
        }
    }
}
