﻿using System;
using DesignPatterns.flyweight;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {            
            CoffeeShop s = new CoffeeShop();
            Order c = new Order();
            c.addItem("Coffee", 5);
            c.addItem("Cake", 2);
            s.prepareOrder(c).ForEach(x => Console.WriteLine(x.name));
        }
    }
}