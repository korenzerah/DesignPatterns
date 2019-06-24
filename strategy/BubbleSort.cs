using System;
namespace DesignPatterns.strategy
{
    public class BubbleSort : ISortStrategy
    {
        public void Sort(int[] data)
        {
            Console.WriteLine("Bubble sorting");
        }
    }
}