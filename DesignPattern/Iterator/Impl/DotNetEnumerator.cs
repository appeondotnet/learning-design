using System.Collections;

namespace Iterator
{
    public class DotNetEnumerator : IEnumerator
    {
        private int _index = -1;
        private readonly string[] _array;

        public DotNetEnumerator(string[] array)
        {
            _array = array;
        }

        public object Current => _array[_index];

        public bool MoveNext()
        {
            if (_index < _array.Length - 1)
            {
                _index++;

                return true;
            }

            return false;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
