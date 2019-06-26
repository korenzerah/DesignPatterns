using System;
namespace DesignPatterns.command
{
    public class WindowsMachine : IMachine
    {
        public bool canTurnOn()
        {
            return true;
        }

        public void startVirusScan()
        {
            Console.WriteLine("Start windows virus scan");
        }

        public void stopVirusScan()
        {
            Console.WriteLine("stop windows virus scan");
        }

        public void turnOff()
        {
            Console.WriteLine("Turn windows off");
        }

        public void turnOn()
        {
            Console.WriteLine("Turn windows on");
        }
    }
}