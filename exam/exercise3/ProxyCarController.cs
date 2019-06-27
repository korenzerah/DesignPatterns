namespace DesignPatterns.exam.exercise3
{
    public class ProxyCarController : ICarDisplay
    {
        public CarController carController {get; set;}

        public ProxyCarController(CarController c) {
            this.carController = c;
        }

        public void DisplayGasLevel()
        {
            this.carController.DisplayGas();
        }

        public void DisplayLocation()
        {
            this.carController.DisplayLocation();
        }
    }
}