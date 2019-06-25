using System;

namespace DesignPatterns.mediator
{
    public class TadiranCompany : Colleague
    {
        public TadiranCompany(Mediator med) : base(med)
        {
            Console.WriteLine("Tadiran signed up!");
            this.mediator.addColleague(this);
        }
    }
}