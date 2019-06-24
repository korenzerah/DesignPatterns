using System;
using System.Collections.Generic;

namespace DesignPatterns.composite
{
    public class Leaf : Component
    {

        public Leaf(string name): base(name) {}

        public override void addChild(Component newChild)
        {
            throw new System.NotSupportedException();
        }

        public override void Draw()
        {
            Console.WriteLine(this.name);
        }

        public override bool isBinary() {
            return true;
        }

        public override List<Component> getChildren()
        {
            return null;
        }

        public override void removeChild(Component child)
        {
            throw new System.NotSupportedException();
        }
    }
}