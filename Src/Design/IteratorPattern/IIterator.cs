using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
