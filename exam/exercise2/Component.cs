using System.Collections.Generic;
namespace DesignPatterns.exercise2
{
    public abstract class Component
    {
        public int value {get; private set;}
        public abstract void addChild(Component newChild);
        public abstract void removeChild(Component child);
        public abstract List<Component> getChildren();
        public abstract int Sum();
        public abstract bool isEven();

        public Component(int value) {
            this.value = value;
        }
    }
}