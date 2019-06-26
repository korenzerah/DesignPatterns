using System;

namespace DesignPatterns.command
{
    public class TurnOffMachine : CommandBase
    {
        public TurnOffMachine(IMachine m) : base(m)
        {
        }

        public override void Cancel()
        {
            Console.WriteLine("Turning on the machine");
            this.machine.turnOn();
        }

        public override void Execute()
        {
            Console.WriteLine("Turning off the machine");
            this.machine.turnOff();
        }
    }
}