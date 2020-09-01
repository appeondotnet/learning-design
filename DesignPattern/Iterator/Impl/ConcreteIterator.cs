namespace Iterator
{
    public class ConcreteIterator : Iterator
    {
        private int _count;
        private readonly ConcreteAggregate _aggregate;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return _aggregate[_count];
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override bool IsDone()
        {
            return _count >= _aggregate.Count;
        }

        public override object Next()
        {
            object obj = null;

            if (_count < _aggregate.Count)
            {
                obj = _aggregate[_count];

                _count++;
            }

            return obj;
        }
    }
}
