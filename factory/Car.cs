namespace DesignPatterns {
    public class Car : Vehicle
    {
        private string year;
        public Car(string model, string year) : base(model) {
            this.year = year;
        }

        public override string ToString() {
            return base.ToString() + ", year: " + this.year;
        }
    }
}