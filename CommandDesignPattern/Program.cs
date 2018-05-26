using System;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            # 命令模式
                将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化；对请求排队或记录请求日志，以及支持可撤销的操作。
                命令模式将客户端与具体执行操作的类分离，通过Invoker类操作Command对象，Command类绑定具体操作类，调用具体操类完成相关操作。
                Invoker类对Command是一种聚合关系，可以对Command进行一些列操作，例如控制命令执行，设计命令队列等。
            ## 优点
                1. 可以较容易地设计一个命令模式；
                2. 在需要的情况下，可以较容易地将命令记入日志；
                3. 允许接收请求的一方决定是否要否决请求；
                4. 可以容易地实现对命令的撤销和重做；
                5. 已扩展新的具体命令类，新增命令类对其他类不会产生影像。
             */
            Barbecuer boy = new Barbecuer();
            Command bakeMutton1 = new BakeMuttonCommand(boy);
            Command bakeMutton2 = new BakeMuttonCommand(boy);
            Command bakeMutton3 = new BakeMuttonCommand(boy);

            Command bakeChickenWing = new BakeChickenWingCommand(boy);
            
            Waiter girl = new Waiter();
            girl.SetOrder(bakeMutton1);
            girl.SetOrder(bakeMutton2);
            girl.SetOrder(bakeMutton3);
            girl.SetOrder(bakeChickenWing);

            girl.CancelOrder(bakeMutton3);

            girl.Notify();

        }
    }
}
