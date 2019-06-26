using System;
namespace DesignPatterns.observer
{
    public class StockObserver : IObserver
    {
        public void update(double ibmPrice, double applePrice, double googlePrice)
        {
            Console.WriteLine("Received a change!!! wohoooo");
        }
    }
}