using System;
namespace DesignPatterns.command
{
    public class LinuxMachine : IMachine
    {
        public bool canTurnOn()
        {
            return true;
        }

        public void startVirusScan()
        {
            Console.WriteLine("Start linux virus scan");
        }

        public void stopVirusScan()
        {
            Console.WriteLine("stop linux virus scan");
        }

        public void turnOff()
        {
            Console.WriteLine("Turn linux off");
        }

        public void turnOn()
        {
            Console.WriteLine("Turn linux on");
        }
    }
}