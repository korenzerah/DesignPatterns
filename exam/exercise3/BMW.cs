using System;
namespace DesignPatterns.exam.exercise3
{
    public class BMW : Car
    {
        public override void DisplayGasLevel()
        {
            Console.WriteLine("BMW Gas level is displayed!");
        }

        public override void DisplayLocation()
        {
            Console.WriteLine("BMW location is displayed!");
        }

        public override void TurnLeft()
        {
            Console.WriteLine("BMW turned left!");
        }

        public override void TurnRight()
        {
            Console.WriteLine("BMW turned right!");
        }
    }
}