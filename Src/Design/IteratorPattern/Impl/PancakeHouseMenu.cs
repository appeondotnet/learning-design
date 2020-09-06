using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class PancakeHouseMenu : IMenu
    {
        private readonly IList<IMenuItem> _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new List<IMenuItem>();
        }

        public void AddMenuItem(string name, string descripton, decimal price)
        {
            var menuItem = new MenuItem(name, descripton, price);

            _menuItems.Add(menuItem);
        }

        public IIterator CreateIterator()
        {
            return new ListIterator<IMenuItem>(_menuItems);
        }
    }
}
