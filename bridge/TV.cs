using System;
namespace DesignPatterns.bridge
{
    public class TV : EntertainmentDevice
    {
        public override void nextPressed()
        {
            this.state++;
            Console.WriteLine($"Changing TV channel to {this.state}");
        }

        public override void prevPressed()
        {
            this.state--;
            Console.WriteLine($"Changing TV channel to {this.state}");
        }

        public override void printStatus()
        {
            Console.WriteLine($"TV status is {this.isOn}");
        }
    }
}