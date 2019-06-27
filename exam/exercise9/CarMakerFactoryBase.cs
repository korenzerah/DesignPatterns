using System;
namespace DesignPatterns.exam.exercise9
{
    public abstract class CarMakerFactoryBase
    {
        public abstract EngineBase createEngine();
        public abstract ACBase createAC();
        public abstract LightSystemBase createLightSystem();
        public abstract BateryBase createBatery();
        public Tin createTin() {
            Console.WriteLine("Creating tin");
            return new Tin();
        }

        public Wheels createWheels() {
            Console.WriteLine("Creating wheels");
            return new Wheels();
        }

        public Seats createSeats() {
            Console.WriteLine("Creating seats");
            return new Seats();
        }
    }
}