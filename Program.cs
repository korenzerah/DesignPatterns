﻿using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VehicleFactory.CreateVehicle("Car").ToString());
            Console.WriteLine(VehicleFactory.CreateVehicle("Tank").ToString());
            Console.WriteLine(VehicleFactory.CreateVehicle("Bike") == null);
        }
    }
}
