using System;
using System.Collections.Generic;

namespace DesignPatterns.exercise2
{
    public class Leaf : Component
    {

        public Leaf(int value): base(value) {}

        public override void addChild(Component newChild)
        {
            throw new System.NotSupportedException();
        }

        public override int Sum()
        {
            return this.value;
        }

        public override bool isEven() {
            return this.value % 2 == 0;
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