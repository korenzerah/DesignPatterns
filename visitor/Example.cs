using System;

namespace DesignPatterns.visitor
{
    class MainOfVisitor
    {
        static void Example(string[] args)
        {
            Shape c = new Circle();
            c.Accept(new Paint());
            c.Accept(new Shadow());
            c = new Rectangle();
            c.Accept(new Paint());
            c.Accept(new Shadow());
        }
    }
}
