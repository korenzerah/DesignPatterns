using System;

namespace DesignPatterns.builder
{
    class MainOfBuilder
    {
        static void Example(string[] args)
        {
            ChickenSaladBuilder c = new ChickenSaladBuilder();
            c.buildSalad();
            Console.WriteLine(c.ToString());            
            ErezSaladBuilder c2 = new ErezSaladBuilder();
            c2.buildSalad();
            Console.WriteLine(c2.ToString());            
        }
    }
}
