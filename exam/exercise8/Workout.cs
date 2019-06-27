using System;
namespace DesignPatterns.exam.exercise8
{
    public class Workout
    {
        public void ChangeClothes() {
            Console.WriteLine("Changed clothes!");
        }

        public void DrinkWater() {
            Console.WriteLine("Drank water");
        }

        public void DoExercise(string exerciseName) {
            Console.WriteLine($"Doing {exerciseName} exercise!");
        }

        public void Shower() {
            Console.WriteLine("Doing a shower!");
        }
    }
}