using System.Collections.Generic;
namespace DesignPatterns.composite
{
    public abstract class Component
    {
        protected string name;
        public abstract void addChild(Component newChild);
        public abstract void removeChild(Component child);
        public abstract List<Component> getChildren();
        public abstract void Draw();

        public abstract bool isBinary();

        public Component(string name) {
            this.name = name;
        }
    }
}