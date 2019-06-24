using System;
using DesignPatterns.template_method;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {            
            OracleQuery q = new OracleQuery();
            q.run();
        }
    }
}
