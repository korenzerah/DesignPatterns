using System;
namespace DesignPatterns.exam.exercise1
{
    public class SpaceShip
    {
        public int points {get; private set;}
        public SpaceShip() {
            this.points = 50;
        }

        public void hit(int points) {            
            this.points -= points;
            Console.WriteLine("Spaceship got hit! current points is:" + this.points);
        }
    }
}