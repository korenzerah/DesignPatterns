﻿using System;
using DesignPatterns.visitor;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {            
            Shape c = new Circle();
            c.Accept(new Paint());
            c.Accept(new Shadow());
            c = new Rectangle();
            c.Accept(new Paint());
            c.Accept(new Shadow());
        }
    }
}