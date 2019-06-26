using System;

namespace DesignPatterns.command
{
    public class TurnOnInvoker : OperationInvoker
    {
        public TurnOnInvoker(TurnOnMachine com) : base(com)
        {
        }

        public override void Cancel()
        {            
            this.command.Cancel();
        }

        public override void Execute()
        {
            if (this.command.machine.canTurnOn())
                this.command.Execute();
                Console.WriteLine(this.num);
        }
    }
}