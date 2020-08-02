using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    internal class PancakeHouseMenu
    {
        private readonly ArrayList _menuItems;

        public readonly static int MAX_ITEMS = 6;
        public int numberOfItems = 0;

        public PancakeHouseMenu(ArrayList menuItems)
        {
            _menuItems = menuItems;
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseIterator(_menuItems);
        }
    }
}
