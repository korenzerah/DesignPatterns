using System;
using System.Collections.Generic;

namespace DesignPatterns.composite
{
    public class Composite : Component
    {
        List<Component> children = new List<Component>();
        
        public Composite(string name): base(name) {}
        public override void addChild(Component newChild)
        {
            this.children.Add(newChild);
        }

        public override void Draw()
        {
            Console.WriteLine(this.name);
            foreach(Component c in this.children) {
                c.Draw();
            }
        }

        public override List<Component> getChildren()
        {
            return this.children;
        }

        public override bool isBinary() {
            if (this.getChildren().Count == 0) {
                return true;
            } else if (this.getChildren().Count != 2) {
                return false;
            } else {
                return this.getChildren()[0].isBinary() && this.getChildren()[1].isBinary();
            }            
        }

        public override void removeChild(Component child)
        {
            this.children.Remove(child);
        }
    }
}