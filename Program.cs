﻿using System;
using DesignPatterns.observer;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {            
            StockObserver so = new StockObserver();
            StockGrabber sg = new StockGrabber();
            sg.setApplePrice(50);
            sg.register(so);
            sg.setApplePrice(51);
        }
    }
}