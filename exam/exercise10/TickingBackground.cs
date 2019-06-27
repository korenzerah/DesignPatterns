using System;

namespace DesignPatterns.exam.exercise10
{
    public class TickingBackground : WindowHandler
    {
        public TickingBackground()
        {
        }

        public override void handle()
        {
            Console.WriteLine("Adding a ticking background");
            if(this.next != null) {
                this.next.handle();
            }
        }
    }
}