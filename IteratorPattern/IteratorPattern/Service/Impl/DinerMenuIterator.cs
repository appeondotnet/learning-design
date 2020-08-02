using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    internal class DinerMenuIterator : IIterator
    {
        private readonly MenuItem[] _items;
        private int _position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this._items = items;
        }
        public bool HasNext()
        {
            if (_position > _items.Length - 1 || _items[_position - 1] == null)
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
            return _items[_position++];
        }
    }
}
