using System.Linq;
using System.Collections.Generic;

namespace DesignPatterns.memento
{
    public class CareTaker
    {
        private List<Memento> mems = new List<Memento>();

        public void AddMemento(Memento m) {
            this.mems.Add(m);
        }

        public Memento getLastMomento() {
            Memento m = (Memento)this.mems.Last();
            this.mems.RemoveAt(this.mems.Count - 1);
            return m;
        }
    }
}