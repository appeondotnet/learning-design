using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    internal class PancakeHouseIterator : IIterator
    {
        private readonly ArrayList _menuItems;
        private int _postion = 0;

        public PancakeHouseIterator(ArrayList menuItems)
        {
            _menuItems = menuItems;
        }
        public bool HasNext()
        {
            if (_postion > _menuItems.Count - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            return _menuItems[_postion++];
        }
    }
}
