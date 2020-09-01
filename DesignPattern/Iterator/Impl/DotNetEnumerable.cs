using System.Collections;

namespace Iterator
{
    public class DotNetEnumerable : IEnumerable
    {
        private readonly string[] _array;

        public DotNetEnumerable(string[] array)
        {
            _array = array;
        }

        public IEnumerator GetEnumerator()
        {
            return new DotNetEnumerator(_array);
        }
    }
}
