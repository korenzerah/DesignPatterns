namespace DesignPatterns {
    public class IAmOff : LightState {

        public override turnOn() {
            Console.WriteLine("Turning on...");
            return new IAmOn();
        }
        public override turnOff() {
            Console.WriteLine("I am already off...");
            return this;
        }
    }
}