using System;
namespace DesignPatterns.visitor
{
    public class Paint : IVisitor
    {
        public void visitCircle(Circle c)
        {
            Console.WriteLine("Painting circle!");
        }

        public void visitRectangle(Rectangle r)
        {
            Console.WriteLine("Painting rectangle!");
        }
    }
}