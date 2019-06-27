namespace DesignPatterns.exam.exercise3
{
    public interface ICarFunctions
    {
        void StartDriving();
        void StopDriving();
        void IncreaseSpeed(int speedToAdd);
        void DecreaseSpeed(int speedToDecrease);
        void TurnLeft();
        void TurnRight();
    }
}