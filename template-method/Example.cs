using System;

namespace DesignPatterns.template_method
{
    class MainOfTemplateMethod
    {
        static void Example(string[] args)
        {
            OracleQuery q = new OracleQuery();
            q.run();
        }
    }
}
