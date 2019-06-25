using System;
namespace DesignPatterns.visitor
{
    public class Shadow : IVisitor
    {
        public void visitCircle(Circle c)
        {
            Console.WriteLine("Shadowing Circle!");
        }

        public void visitRectangle(Rectangle r)
        {
            Console.WriteLine("Shadowing rectangle!");
        }
    }
}