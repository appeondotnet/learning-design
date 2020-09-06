using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class MenuItem : IMenuComponent
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

        public void AddMenu(IMenuComponent menu)
        {
            throw new NotSupportedException();
        }

        public IIterator CreateIterator()
        {
            return new NullIterator();
        }

        public void Print()
        {
            Console.WriteLine($"Name:{this.Name}, Description:{this.Description}, Price:{this.Price}");
        }

        public void RemoveMenu(IMenuComponent menu)
        {
            throw new NotImplementedException();
        }
    }
}
