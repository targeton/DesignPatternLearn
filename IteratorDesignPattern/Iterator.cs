namespace IteratorDesignPattern
{
    // 迭代器抽象类，用于定义如何访问聚合类对象
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();        
    }
}