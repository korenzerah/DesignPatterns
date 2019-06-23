using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginContext c = new LoginContext();
            c.init();
            c.failed();
            c.failed();
            c.success();
            c.failed();
            c.failed();
            c.failed();            
        }
    }
}
