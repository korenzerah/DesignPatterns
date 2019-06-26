using System;
namespace DesignPatterns.command
{
    public class VirusScan : CommandBase
    {
        public VirusScan(IMachine m) : base(m)
        {
        }

        public override void Cancel()
        {
            Console.WriteLine("Stoping virus scan");
            this.machine.stopVirusScan();
        }

        public override void Execute()
        {
            Console.WriteLine("Starting virus scan");
            this.machine.startVirusScan();
        }
    }
}