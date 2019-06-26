using System;

namespace DesignPatterns.command
{
    class MainOfCommand
    {
        static void Example(string[] args)
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
