using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class MenuIterator : IIterator
    {
        private readonly Stack<IEnumerator<IMenuComponent>> _stack;

        public MenuIterator(IList<IMenuComponent> menu)
        {
            _stack = new Stack<IEnumerator<IMenuComponent>>();

            _stack.Push(menu.GetEnumerator());
        }
             
        public bool HasNext()
        {
            var enu = _stack.Peek();

            var hasNext = enu.MoveNext();

            if (hasNext)
            {
                return true;
            }
            else
            {
                _stack.Pop();

                return this.HasNext();
            }
        }

        public object Next()
        {
            if (this.HasNext())
            {
                var it = (IIterator)_stack.Peek();

                var com = (IMenuComponent)it.Next();

                if (com is MenuComposite c)
                {
                    //_stack.Push(c.CreateIterator());
                }

                return com;
            }

            return null;
        }
    }
}
