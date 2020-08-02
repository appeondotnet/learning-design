using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public interface IIterator
    {
        bool HasNext();

        object Next();
    }
}
