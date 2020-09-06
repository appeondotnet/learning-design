using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class HashTableIterator : IIterator
    {
        private readonly IList _menuItems;
        private int _currentIndex = 0;

        public HashTableIterator(Hashtable menuItems)
        {
            _menuItems = new ArrayList(menuItems.Values);
        }

        public bool HasNext()
        {
            if (_currentIndex < _menuItems.Count)
            {
                return true;
            }

            return false;
        }

        public object Next()
        {
            if (this.HasNext())
            {
                var item = _menuItems[_currentIndex];

                _currentIndex++;

                return item;
            }

            throw new IndexOutOfRangeException();
        }
    }
}
