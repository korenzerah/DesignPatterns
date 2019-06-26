﻿using System;
using DesignPatterns.command;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {            
            WindowsMachine wm = new WindowsMachine();
            OperationCleanUpService ocus = new OperationCleanUpService();
            OperationInvoker toi = new TurnOnInvoker(new TurnOnMachine(wm));
            toi.num = 5;
            
            toi.Execute();            
            ocus.invokers.Add(toi);
            toi.num = 6;
            toi.Execute();
            toi.Cancel();
            ocus.batchExecute();
        }
    }
}