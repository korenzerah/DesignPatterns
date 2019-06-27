using System;

namespace DesignPatterns.exam.exercise9
{
    public class NormalCarFactory : CarMakerFactoryBase
    {
        public override ACBase createAC()
        {
            Console.WriteLine("Creating normal ac");
            return new NormalAC();
        }

        public override BateryBase createBatery()
        {
            Console.WriteLine("Creating normal batery");
            return new NormalBatery();
        }

        public override EngineBase createEngine()
        {
            Console.WriteLine("Creating normal engine");
            return new NormalEngine();
        }

        public override LightSystemBase createLightSystem()
        {
            Console.WriteLine("Creating normal light system");
            return new NormalLightSystem();
        }
    }
}