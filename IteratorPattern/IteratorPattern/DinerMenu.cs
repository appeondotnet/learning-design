using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    internal class DinerMenu
    {
        public readonly static int MAX_ITEMS = 6;
        public int numberOfItems = 0;
        private readonly MenuItem[] _menuItems;

        public DinerMenu(MenuItem[] menuItems)
        {
            _menuItems = menuItems;
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }
}
