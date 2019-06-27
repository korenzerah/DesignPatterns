using System;

namespace DesignPatterns.exam.exercise5
{
    public class ErrorDecorator : LogDecorator
    {
        public ErrorDecorator(ILog l) : base(l)
        {
        }

        public override void WriteLog()
        {
            this.log.WriteLog();
            Console.WriteLine(" and Writing log to file!");
        }
    }
}