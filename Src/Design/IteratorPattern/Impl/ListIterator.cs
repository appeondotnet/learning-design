using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class ListIterator<TModel> : IIterator
    {
        private readonly IList<TModel> _list;
        private int _currentIndex = 0;

        public ListIterator(IList<TModel> list)
        {
            _list = list;
        }

        public bool HasNext()
        {
            if (_currentIndex < _list.Count)
            {
                return true;
            }

            return false;
        }

        public object Next()
        {
            if (this.HasNext())
            {
                var item = _list[_currentIndex];

                _currentIndex++;

                return item;
            }

            throw new IndexOutOfRangeException();
        }
    }
}
