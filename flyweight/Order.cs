using System.Collections.Generic;
namespace DesignPatterns.flyweight
{
    public class Order
    {
        public Dictionary<string, int> items {get; set;} = new Dictionary<string, int>();

        public void addItem(string nameFlyWeight, int count) {
            if (this.items.ContainsKey(nameFlyWeight)) {
                this.items[nameFlyWeight] += count;
            } else {
                this.items.Add(nameFlyWeight, count);
            }
        }
    }
}