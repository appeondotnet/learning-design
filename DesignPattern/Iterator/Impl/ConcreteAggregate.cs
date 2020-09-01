using System.Collections.Generic;

namespace Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        private readonly IList<object> _items;

        public ConcreteAggregate()
        {
            _items = new List<object>();
        }

        public object this[int index]
        {
            set => _items.Insert(index, value);

            get => _items[index];
        }

        public int Count => _items.Count;

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
