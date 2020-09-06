using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Impl
{
    class DinnerMenu : IMenu
    {
        private IMenuItem[] _menuItems;

        public DinnerMenu(int menuCount)
        {
            _menuItems = new IMenuItem[menuCount];
        }

        public void AddMenuItem(int index, string name, string description, decimal price)
        {
            _menuItems[index] = new MenuItem(name, description, price);
        }

        public IIterator CreateIterator()
        {
            return new ArrayIterator<IMenuItem>(_menuItems);
        }
    }
}
