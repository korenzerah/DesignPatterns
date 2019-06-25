using System;
using DesignPatterns.proxy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {            
            ProxyATM a = new ProxyATM();
            a.getTotal();
        }
    }
}