using System;

namespace DesignPatterns.proxy
{
    class MainOfProxy
    {
        static void Example(string[] args)
        {
            ProxyATM a = new ProxyATM();
            a.getTotal();
        }
    }
}
