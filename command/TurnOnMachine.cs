using System;

namespace DesignPatterns.command
{
    public class TurnOnMachine : CommandBase
    {
        public TurnOnMachine(IMachine m) : base(m)
        {
        }

        public override void Cancel()
        {
            Console.WriteLine("Turning off the machine");
            this.machine.turnOff();
        }

        public override void Execute()
        {
            Console.WriteLine("Turning on the machine");
            this.machine.turnOn();
        }
    }
}