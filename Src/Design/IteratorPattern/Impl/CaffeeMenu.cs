using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Impl
{
    class CaffeeMenu : IMenu
    {
        private readonly Hashtable _menuItems;

        public CaffeeMenu()
        {
            _menuItems = new Hashtable();
        }

        public void AddMenuItem(string name, string description, decimal price)
        {
            _menuItems.Add(name, new MenuItem(name, description, price));
        }

        public IIterator CreateIterator()
        {
            return new HashTableIterator(_menuItems);
        }
    }
}
