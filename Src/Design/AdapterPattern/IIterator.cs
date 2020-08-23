using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface IIterator<out T> : IDisposable
    {
        T Current { get; }
        bool MoveNext();
        void Reset();
        bool Remove();
    }
}
