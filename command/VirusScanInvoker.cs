using System;
namespace DesignPatterns.command
{
    public class VirusScanInvoker : OperationInvoker
    {
        public VirusScanInvoker(CommandBase com) : base(com)
        {
        }

        public override void Cancel()
        {
            this.command.machine.stopVirusScan();
        }

        public override void Execute()
        {
            // repeat every 30 seconds
            this.command.machine.startVirusScan();
            Console.WriteLine(this.num);
        }
    }
}