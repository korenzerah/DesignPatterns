using System.Linq;
using System.Collections.Generic;
namespace DesignPatterns.flyweight
{
    public static class FactoryKitchen
    {
        public static List<ItemFromMenu> prepareItem(string name, int amount) {            
            return Enumerable.Repeat(new ItemFromMenu(name), amount).ToList();
        }
    }
}