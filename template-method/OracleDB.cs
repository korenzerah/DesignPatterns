using System;
namespace DesignPatterns.template_method
{
    public abstract class OracleDB : TemplateQuery
    {
        public override void closeConnection()
        {
            Console.WriteLine("Closing oracle connection");
        }

        public override void openConnection()
        {
            Console.WriteLine("opening oracle connection");
        }        
    }
}