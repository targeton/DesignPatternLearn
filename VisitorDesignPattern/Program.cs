using System;

namespace VisitorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            # 访问者模式
                表示一个作用于某对象结构中的各元素的操作。它使你可以在不改变各元素的类的前提下定义作用于这些元素的新操作。

            ## 应用场景
                访问者模式适用于数据结构相对稳定的系统，它把数据结构和作用于结构上的操作之间的耦合解脱开，使得操作集合可以相对地自由地演化。
                访问者模式的目的是要把处理从数据结构中分离出来。如果系统有比较稳定的数据结构，又有易于变化的算法的话，适合使用访问者模式。

            ## 优点缺点
                优点：增加新的操作很容易，因为增加新的操作就意味着增加一个新的访问者，访问者模式将有关的行为集中到一个访问对象中。
                缺点：增加新的数据结构变得困难了，数据结构发生变动的话，访问者模式中的Visitor基类需要增加新的方法，每个具体Visitor类也将需要修改，改动量很大。                
             */
            
            // 以下示例中数据结构只有Man和Woman两种，数据结构稳定，针对数据结构的操作就是不同的状态（成功、失败、恋爱）等
            // 若需要增加对数据结构的新操作时，只需要扩展Visitor类即可。
            ObjectStructure o = new ObjectStructure();
            o.Attach(new Man());
            o.Attach(new Woman());

            Success v1 = new Success();
            o.Display(v1);

            Failing v2 = new Failing();
            o.Display(v2);

            Amativeness v3 = new Amativeness();
            o.Display(v3);
        }
    }
}
