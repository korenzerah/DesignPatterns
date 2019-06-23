namespace DesignPatterns {
    public class IAmOn : LightState {
        public override turnOn() {
            Console.WriteLine("I am already on, I got broken now...");
            return new IAmBroken();
        }

        public override turnOff() {
            Console.WriteLine("Turning off...");
            return new IAmOff();
        }
    }
}