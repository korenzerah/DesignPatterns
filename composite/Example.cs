using System;

namespace DesignPatterns.composite
{
    class MainOfComposite
    {
        static void Example(string[] args)
        {
            Component c = new Composite("root");
            Composite c1 = new Composite("child1");
            Composite c2 = new Composite("child2");
            c1.addChild(new Composite("bla1"));
            c1.addChild(new Composite("bla2"));
            // c1.addChild(new Leaf("child3"));
            // c1.addChild(new Leaf("child4"));
            c2.addChild(new Leaf("child5"));
            c2.addChild(new Leaf("child6"));

            c.addChild(c1);
            c.addChild(c2);

            Console.WriteLine(c.isBinary());
        }
    }
}