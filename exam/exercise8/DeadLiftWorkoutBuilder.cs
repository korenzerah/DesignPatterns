namespace DesignPatterns.exam.exercise8
{
    public class DeadLiftWorkoutBuilder : BaseWorkoutBuilder
    {
        protected override void DoExercise()
        {
            this.workout.DoExercise("Deadlift");
        }
    }
}