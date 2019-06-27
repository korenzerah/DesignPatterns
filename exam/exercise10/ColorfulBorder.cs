using System;

namespace DesignPatterns.exam.exercise10
{
    public class ColorfulBorder : WindowHandler
    {
        public ColorfulBorder()
        {
        }

        public override void handle()
        {
            Console.WriteLine("Adding a colorful border!");
            if(this.next != null) {
                this.next.handle();
            }
        }
    }
}