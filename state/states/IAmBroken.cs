namespace DesignPatterns {
    public class IAmBroken : LightState {

        public override turnOn() {
            Console.WriteLine("I am broken, can't turn on...");
            return this;
        }
        public override turnOff() {
            Console.WriteLine("I am broken, can't turn off...");
            return this;
        }
    }
}