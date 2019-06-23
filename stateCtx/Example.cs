using System;

namespace DesignPatterns
{
    class MainOfStateCTX
    {
        static void Example(string[] args)
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
