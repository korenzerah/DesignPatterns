using System;

namespace DesignPatterns.exam.exercise5
{
    public class FatalDecorator : LogDecorator
    {
        public FatalDecorator(ILog l) : base(l)
        {
        }

        public override void WriteLog()
        {
            this.log.WriteLog();
            Console.WriteLine(" and sending an SMS to the system manager!");
        }
    }
}