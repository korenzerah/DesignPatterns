using System;
using System.Collections.Generic;

namespace DesignPatterns.exercise2
{
    public class Composite : Component
    {
        List<Component> children = new List<Component>();
        
        public Composite(int value): base(value) 
        {
        }
        public override void addChild(Component newChild)
        {
            this.children.Add(newChild);
        }

        public override int Sum()
        {
            int sum = this.value;
            foreach(Component c in this.children) {
                sum += c.Sum();
            }

            return sum;
        }

        public override List<Component> getChildren()
        {
            return this.children;
        }

        public override bool isEven() {
            return this.value % 2 == 0;
        }

        public override void removeChild(Component child)
        {
            this.children.Remove(child);
        }
    }
}