using System.Collections.Generic;
using System.Linq;
namespace DesignPatterns.flyweight
{
    public class CoffeeShop
    {
        public List<ItemFromMenu> prepareOrder(Order order) {
            List<ItemFromMenu> itemsFromMenu = new List<ItemFromMenu>();
            
            foreach(var item in order.items) {
                itemsFromMenu.AddRange(FactoryKitchen.prepareItem(item.Key, item.Value));
            }

            return itemsFromMenu;
        }
    }
}