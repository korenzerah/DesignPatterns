﻿using System;
using DesignPatterns.strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {            
            DataContainer dd = new DataContainer(new QuickSort());
            dd.Sort();
            dd.setSortStrategy(new BubbleSort());
            dd.Sort();
        }
    }
}
