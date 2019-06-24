using System;

namespace DesignPatterns.strategy
{
    class MainOfStrategy
    {
        static void Example(string[] args)
        {
            DataContainer dd = new DataContainer(new QuickSort());
            dd.Sort();
            dd.setSortStrategy(new BubbleSort());
            dd.Sort();
        }
    }
}
