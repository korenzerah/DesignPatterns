using System.Collections.Generic;

namespace DesignPatterns.flyweight
{
    public class ItemFromMenu
    {
        public string name {get; set;}

        public ItemFromMenu(string name)
        {
            this.name = name;
        }
    }
}