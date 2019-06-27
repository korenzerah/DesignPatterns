using System;
namespace DesignPatterns.exam.exercise3
{
    public class Mercedes : Car
    {
        public override void DisplayGasLevel()
        {
            Console.WriteLine("Mercedes Gas level is displayed!");
        }

        public override void DisplayLocation()
        {
            Console.WriteLine("Mercedes location is displayed!");
        }

        public override void TurnLeft()
        {
            Console.WriteLine("Mercedes turned left!");
        }

        public override void TurnRight()
        {
            Console.WriteLine("Mercedes turned right!");
        }
    }
}