using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class MenuItem : IMenuItem
    {
        public MenuItem(string name, string description, decimal price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
        public string Name { get; }

        public string Description { get; }

        public decimal Price { get; }
    }
}
