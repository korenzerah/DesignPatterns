using System;
namespace DesignPatterns.decorator
{
    public class BasePizza : IPizza
    {
        public string getDetails()
        {
            return "base pizza details";
        }

        public double getPrice()
        {
            return 5;
        }
    }
}