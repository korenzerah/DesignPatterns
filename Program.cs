﻿using System;
using DesignPatterns.prototype;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {            
            Circle m = new Circle(new Point(1, 2), 55);
            Console.WriteLine(m.area);
            giveMeYourCircle(m.Clone());
            Console.WriteLine(m.area);
        }

        private static void giveMeYourCircle(Circle c) {
            c.area = 3;
        }
    }
}
