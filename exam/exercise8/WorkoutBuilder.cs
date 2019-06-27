namespace DesignPatterns.exam.exercise8
{
    public abstract class WorkoutBuilder
    {
        protected Workout workout;

        public virtual void buildWorkout() {
            this.workout = new Workout();
            this.ChangeClothes();
            this.DrinkWater();
            this.DoExercise();
            this.Shower();
        }

        protected abstract void ChangeClothes();
        protected abstract void DrinkWater();
        protected abstract void DoExercise();
        protected abstract void Shower();
    }
}