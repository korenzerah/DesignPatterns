using System;
namespace DesignPatterns {
    public class IAmOn : LightState {
        public override LightState turnOn() {
            Console.WriteLine("I am already on, I got broken now...");
            return new IAmBroken();
        }

        public override LightState turnOff() {
            Console.WriteLine("Turning off...");
            return new IAmOff();
        }
        public override LightState fix(){
            Console.WriteLine("Nothing to fix. I am On'.");
            return this;
        }
    }
}