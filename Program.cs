﻿using System;
using DesignPatterns.bridge;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {            
            TV t = new TV();
            Memir m = new Memir();
            RemoteControl rc = new RemoteControl(t);
            rc.pressOn();
            rc.pressOff();
            rc.prevPressed();
            rc.device = m;
            rc.pressOn();
            rc.nextPressed();
        }
    }
}