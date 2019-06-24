﻿using System;
using DesignPatterns.builder;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {            
            ChickenSaladBuilder c = new ChickenSaladBuilder();
            c.buildSalad();
            Console.WriteLine(c.ToString());            
            ErezSaladBuilder c2 = new ErezSaladBuilder();
            c2.buildSalad();
            Console.WriteLine(c2.ToString());            
        }
    }
}
