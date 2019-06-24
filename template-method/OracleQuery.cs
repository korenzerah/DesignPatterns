using System;
namespace DesignPatterns.template_method
{
    public class OracleQuery : OracleDB
    {
        public override void runQuery()
        {            
            Console.WriteLine("Running query");
        }
    }
}