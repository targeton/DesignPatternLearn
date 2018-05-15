using System;
using MediatorDesignPattern.CSharp;
using MediatorDesignPattern.Normal;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Normal 当类与类之间需要复杂交互时，则引入中间类，将系统的复杂性集中于中间者类中，在面对多对多交互时，可以考虑该模式
            // //当存在多对多的复杂交互时，因优先考虑系统本身的设计性问题，而不是着急使用中间者模式
            // System.Console.WriteLine("Normal Mediator Design Pattern");
            // ConcreteMediator mediator = new ConcreteMediator();
            // ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            // ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);
            // mediator.Colleague1 = colleague1;
            // mediator.Colleague2 = colleague2;
            // colleague1.Send("这是新的需求，赶紧完成！");
            // colleague2.Send("系统设计模式有问题，实现需求会很麻烦！");

            // C# 利用委托实现消息中心类，当类与类需要交互时，只需一个类注册服务，另一个类通过消息中心向该服务发送信息即可
            // 消息中信类不需要指导参与交互的类，极大地减小了中间者类的复杂性
            Concrete1 conrete1 = new Concrete1();
            Concrete2 conrete2 = new Concrete2();
            conrete2.SendMessage("Hello","Seven");
            conrete2.SendMessage("I","Love","You");
        }
    }
}
