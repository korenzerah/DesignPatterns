using System;
namespace DesignPatterns.strategy
{
    public class QuickSort : ISortStrategy
    {
        public void Sort(int[] data)
        {
            Console.WriteLine("Quick sorting!");
        }
    }
}