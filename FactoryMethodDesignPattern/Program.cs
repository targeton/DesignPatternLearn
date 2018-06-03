using System;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        //工厂方法模式：定义一个用于创建对象的接口，让子类决定实例化哪一个类，工厂方法使一个类的实例化延迟到其子类
        //需要扩展时，只需要新实现一个Operation的子类，并实现一个创建该子类的工厂类，只需修改客户端创建工厂类的语句即可，实现了开放扩展，关闭更改的要求
        static void Main(string[] args)
        {
            IOperationFactory factory = new PowerOperationFactory();
            Operation operation = factory.CreateOperation();
            var result = operation.GetResult(15.0, 3.0);
            System.Console.WriteLine("Operation's Result is {0}", result);
        }
    }
}
