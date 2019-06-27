using System;

namespace DesignPatterns.exam.exercise9
{
    public class HybridCarFactory : CarMakerFactoryBase
    {
        public override ACBase createAC()
        {
            Console.WriteLine("Creating hybrid ac");
            return new HybridAC();
        }

        public override BateryBase createBatery()
        {
            Console.WriteLine("Creating hybrid batery");
            return new HybridBatery();
        }

        public override EngineBase createEngine()
        {
            Console.WriteLine("Creating hybrid engine");
            return new HybridEngine();
        }

        public override LightSystemBase createLightSystem()
        {
            Console.WriteLine("Creating hybrid light system");
            return new HybridLightSystem();
        }
    }
}