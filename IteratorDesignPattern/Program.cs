using System;

namespace IteratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            # 迭代器模式
                提供一种方法顺序访问一个聚合对象中各个元素，而又不暴露该对象的内部表示

            ## 应用场景
                当需要访问一个聚焦对象，而且不管这些对象是什么都需要遍历的时候，就应该考虑用迭代器模式。
                当需要对聚集有多种方式遍历时，可以考虑用迭代器模式。
                foreach in 就是迭代器模式的实现
             */
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "赵大";
            a[1] = "钱二";
            a[2] = "孙三";
            a[3] = "李四";
            Iterator i = new ConcreteIterator(a);
            object item = i.First();
            while (!i.IsDone())
            {
                System.Console.WriteLine("{0} 请登记！",i.CurrentItem());
                i.Next();
            }
        }
    }
}
