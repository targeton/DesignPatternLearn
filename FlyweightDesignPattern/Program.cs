using System;

namespace FlyweightDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            # 享元模式
                运用共享技术有效地支持大量细粒度的对象，可以避免大量非常相似类的内存开销。
                可以注重比较单例模式、享元模式、IOC容器之间的联系和区别。
            
            ## 应用场景
                在程序设计时，有时需要生成大量细粒度的类实例来表示数据，如果能够发现这些实例除了几个参数外基本上都是相同的，
                有时就能够接受大幅度地减少需要实例化的类数量。如果能够把那些参数移到类实例的外面，在方法调用时将它们传递进来，
                就可以通过共享（享元模式）大幅度地减少单个实例的数目。
            
            ## 重要类
                1. 享元工厂类：用户通过该工厂类获取享元类对象，当用户请求对象时，该工厂提供一个已创建的实例或者创建一个（如果对象不存在）。
                2. 享元类：所有具体享元类的超类，内部属性为共享状态（内部状态），可设置方法接受并作用于外部状态。
            
             */
            WebSiteFactory factory = new WebSiteFactory();

            WebSite fx = factory.GetWebSiteCategory("产品展示");
            fx.Use();

            WebSite fy = factory.GetWebSiteCategory("产品展示");
            fy.Use();

            WebSite fz = factory.GetWebSiteCategory("产品展示");
            fz.Use();

            WebSite f1 = factory.GetWebSiteCategory("博客");
            f1.Use();

            WebSite f2 = factory.GetWebSiteCategory("博客");
            f2.Use();

            WebSite f3 = factory.GetWebSiteCategory("博客");
            f3.Use();

            System.Console.WriteLine("网站分类总数为：{0}",factory.GetWebSiteCount());

        }
    }
}
