using System;
namespace DesignPatterns {
    public class IAmBroken : LightState {

        public override LightState turnOn() {
            Console.WriteLine("I am broken, can't turn on...");
            return this;
        }
        public override LightState turnOff() {
            Console.WriteLine("I am broken, can't turn off...");
            return this;
        }

        public override LightState fix() {
            Console.WriteLine("Fixing the broken light...");
            return new IAmOff();
        }
    }
}