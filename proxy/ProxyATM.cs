using System;
namespace DesignPatterns.proxy
{
    public class ProxyATM : IMonitorService
    {
        ATM a = new ATM();
        public void getTotal()
        {
            Console.WriteLine("Please enter password");
            string pwd = Console.ReadLine();
            
            if (pwd == "1234")
                a.getTotal();
        }
    }
}