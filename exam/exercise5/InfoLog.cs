using System;
namespace DesignPatterns.exam.exercise5
{
    public class InfoLog : ILog
    {
        public void WriteLog()
        {
            Console.WriteLine("Writing log to console");
        }
    }
}