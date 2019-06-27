using System;

namespace DesignPatterns.exam.exercise10
{
    public class D3Light : WindowHandler
    {
        public D3Light()
        {
        }

        public override void handle()
        {
            Console.WriteLine("Adding 3d light!");
            if(this.next != null) {
                this.next.handle();
            }
        }
    }
}