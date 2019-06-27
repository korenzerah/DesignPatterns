namespace DesignPatterns.exam.exercise8
{
    public class SquatWorkoutBuilder : BaseWorkoutBuilder
    {
        protected override void DoExercise()
        {
            this.workout.DoExercise("Squat");
        }        
    }
}