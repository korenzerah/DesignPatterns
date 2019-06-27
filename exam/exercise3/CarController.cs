namespace DesignPatterns.exam.exercise3
{
    public class CarController
    {
        public Car car {get; set;}

        public CarController(Car c1)
        {
            this.car = c1;
        }

        public void StartDriving() {
            this.car.StartDriving();
        }
        public void StopDriving() {
            this.car.StopDriving();
        }
        public void IncreaseSpeed(int speedToAdd) {
            this.car.IncreaseSpeed(speedToAdd);
        }
        public void DecreaseSpeed(int speedToDecrease) {
            this.car.DecreaseSpeed(speedToDecrease);
        }

        public void TurnLeft() {
            this.car.TurnLeft();
        }

        public void TurnRight() {
            this.car.TurnRight();
        }

        public void DisplayGas() {
            this.car.DisplayGasLevel();
        }

        public void DisplayLocation() {
            this.car.DisplayLocation();
        }
    }
}