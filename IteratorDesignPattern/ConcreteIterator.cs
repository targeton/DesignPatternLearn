namespace IteratorDesignPattern
{
    public class ConcreteIterator : Iterator
    {
        public ConcreteAggregate _aggregate;
        private int _current = 0;
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }
        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count ? true : false;
        }

        public override object Next()
        {
            object ret = null;
            _current++;
            if (_current < _aggregate.Count)
                ret = _aggregate[_current];
            return ret;
        }
    }
}