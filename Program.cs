﻿using System;
using DesignPatterns.decorator;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {            
            BasePizza p = new BasePizza();
            Console.WriteLine(p.getDetails());
            Console.WriteLine(p.getPrice());

            MozzarellaTopping d1 = new MozzarellaTopping(p);
            Console.WriteLine(d1.getDetails());
            Console.WriteLine(d1.getPrice());

            PineAppleTopping d2 = new PineAppleTopping(d1);
            Console.WriteLine(d2.getPrice());
        }
    }
}