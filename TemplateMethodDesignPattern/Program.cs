using System;

namespace TemplateMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 模板方法模式：定义一个操作中的算法骨架，而将一些步骤延迟到子类中，
            // 把不变和变化分离，不变的部分提取到基类
            AbstractClass a = new ConcreteClassA();
            AbstractClass b = new ConcreteClassB();

            a.TemplateMethod();
            b.TemplateMethod();
        }
    }
}
