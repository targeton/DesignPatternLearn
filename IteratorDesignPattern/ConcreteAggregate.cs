using System.Collections.Generic;

namespace IteratorDesignPattern
{
    public class ConcreteAggregate : Aggregate
    {
        private IList<object> _items = new List<object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}