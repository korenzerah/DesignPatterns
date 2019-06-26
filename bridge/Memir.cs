using System;
namespace DesignPatterns.bridge
{
    public class Memir : EntertainmentDevice
    {
        public override void nextPressed()
        {
            this.state++;
            Console.WriteLine($"Changing Memir channel to {this.state}");
        }

        public override void prevPressed()
        {
            this.state--;
            Console.WriteLine($"Changing Memir channel to {this.state}");
        }

        public override void printStatus()
        {
            Console.WriteLine($"Memir status is {this.isOn}");
        }
    }
}