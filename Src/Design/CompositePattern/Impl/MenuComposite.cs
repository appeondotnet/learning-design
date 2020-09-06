using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CompositePattern
{
    class MenuComposite : IMenuComponent
    {
        private IList<IMenuComponent> _menus;

        public MenuComposite()
        {
            _menus = new List<IMenuComponent>();
        }

        public MenuComposite(string name, string description)
        {
            _menus = new List<IMenuComponent>();

            this.Name = name;
            this.Description = description;
        }

        public string Name { get; }

        public string Description { get; }

        public decimal Price => throw new NotSupportedException();

        public void AddMenu(IMenuComponent menu)
        {
            _menus.Add(menu);
        }

        public IIterator CreateIterator()
        {
            return new MenuIterator(_menus);
        }

        public void Print()
        {
            Console.WriteLine($"Name:{this.Name}, Description: {this.Description}");

            foreach (var menu in _menus)
            {
                menu.Print();
            }
        }

        public void RemoveMenu(IMenuComponent menu)
        {
            throw new NotImplementedException();
        }
    }
}
