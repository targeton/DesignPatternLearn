using System;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 外观模式：为子系统的一组接口提供一个一致的界面，此模式定义一个高层接口，这一接口使得这一子系统更加容易使用
            // 在开发设计初期的时候，就要有意识地将两个不同的层分离，层与层之间建立外观Facade，有助于减少层与层之间的依赖
            // 外观类对上层调用需提供尽可能简洁明了的方法，对下层引用的类应尽可能整合
            // 客户端和Facade类进行交互，不需要知道各子系统类，而且各子系统类也不需要知道Facade类
            var facade = new Facade();
            facade.MethodA();
            facade.MethodB();
        }
    }
}
