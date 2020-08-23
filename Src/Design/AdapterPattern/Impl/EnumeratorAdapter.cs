using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Impl
{
    public class EnumeratorAdapter<T> : IIterator<T>
    {
        private readonly IEnumerator<T> _enumerator;

        public EnumeratorAdapter(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator;
        }

        public T Current => _enumerator.Current;

        public bool MoveNext()
        {
            return _enumerator.MoveNext();
        }

        public void Reset()
        {
            _enumerator.Reset();
        }

        public void Dispose()
        {
            _enumerator.Dispose();
        }

        public bool Remove()
        {
            throw new NotImplementedException();
        }
    }
}
