using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
