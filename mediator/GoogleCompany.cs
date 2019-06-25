using System;

namespace DesignPatterns.mediator
{
    public class GoogleCompany : Colleague
    {
        public GoogleCompany(Mediator med) : base(med)
        {
            Console.WriteLine("Google signed up!");            
        }
    }
}