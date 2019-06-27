using System;
namespace DesignPatterns.exam.exercise3
{
    public abstract class Car : ICarDisplay, ICarFunctions
    {
        public int speed {get; set;}
        public bool isOn {get; set;}
        public void StartDriving() {
            this.isOn = true;
            Console.WriteLine("Started driving!");
        }
        public void StopDriving() {
            this.isOn = false;
            Console.WriteLine("Stopped driving!");
        }
        public void IncreaseSpeed(int speedToAdd) {
            this.speed += speedToAdd;
            Console.WriteLine("Increased speed by " + speedToAdd);
        }
        public void DecreaseSpeed(int speedToDecrease) {
            this.speed -= speedToDecrease;
            Console.WriteLine("Decreased speed by " + speedToDecrease);
        }
        public abstract void TurnRight();
        public abstract void TurnLeft();
        public abstract void DisplayGasLevel();
        public abstract void DisplayLocation();
    }
}