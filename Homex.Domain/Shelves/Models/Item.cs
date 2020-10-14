using System.Collections.Generic;

namespace Homex.Domain.Shelves.Models
{
    public class Item
    {
        public Item(string name)
        {
            Name = name;
            Aliases = new HashSet<string>{ name };
            IsRemoved = false;
        }

        public string Name { get; set; }

        public Category Category { get; set; }

        public HashSet<string> Aliases { get; set; }

        public bool IsRemoved { get; set; }
    }
}
