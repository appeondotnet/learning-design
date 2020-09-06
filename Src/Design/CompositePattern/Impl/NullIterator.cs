using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class NullIterator : IIterator
    {
        public bool HasNext()
        {
            return false;
        }

        public object Next()
        {
            return null;
        }
    }
}
