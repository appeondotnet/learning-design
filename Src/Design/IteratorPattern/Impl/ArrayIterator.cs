using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Impl
{
    class ArrayIterator<TModel> : IIterator
    {
        private readonly TModel[] _menuItems;
        private int _currentIndex = 0;

        public ArrayIterator(TModel[] items)
        {
            _menuItems = items;
        }

        public bool HasNext()
        {
            if (_currentIndex < this.Size)
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

        private int Size => _menuItems.Length;
    }
}
