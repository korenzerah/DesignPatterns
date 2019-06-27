using System;

namespace DesignPatterns.exam.exercise10
{
    public class Shadow : WindowHandler
    {
        public Shadow()
        {
        }

        public override void handle()
        {
            Console.WriteLine("Adding a shadow!");
            if(this.next != null) {
                this.next.handle();
            }
        }
    }
}