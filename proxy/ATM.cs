using System;
namespace DesignPatterns.proxy
{
    public class ATM : IATM, IMonitorService
    {
        public void deposit(int amount)
        {
            Console.WriteLine($"depositing: {amount}");
        }

        public void getTotal()
        {
            Console.WriteLine("Get total!");
        }

        public void insertCard()
        {
            Console.WriteLine("card inserted!");
        }

        public void removeCard()
        {
            Console.WriteLine("card removed!");
        }

        public void withdraw()
        {
            Console.WriteLine("withdrawn!");
        }
    }
}