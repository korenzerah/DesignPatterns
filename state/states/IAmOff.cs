using System;
namespace DesignPatterns {
    public class IAmOff : LightState {

        public override LightState turnOn() {
            Console.WriteLine("Turning on...");
            return new IAmOn();
        }
        public override LightState turnOff() {
            Console.WriteLine("I am already off...");
            return this;
        }

        public override LightState fix(){
            Console.WriteLine("Nothing to fix. I am Off.");
            return this;
        }
    }
}