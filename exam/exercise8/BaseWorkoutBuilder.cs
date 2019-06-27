namespace DesignPatterns.exam.exercise8
{
    public abstract class BaseWorkoutBuilder : WorkoutBuilder
    {
        protected override void ChangeClothes()
        {
            this.workout.ChangeClothes();
        }
        
        protected override void DrinkWater()
        {
            this.workout.DrinkWater();
        }

        protected override void Shower()
        {
            this.workout.Shower();
        }
    }
}