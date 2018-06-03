using System;

namespace ProxyDesignPattern
{
    class Program
    {
        // ProxyImage为一个代理类，类内含有实际加载图片的RealImage实例，代理模式主要用于不方面直接访问对象的情况，通过代理类间接地进行控制
        // 代理模式、装饰模式以及适配器模式可以横向对比
        static void Main(string[] args)
        {
            Image image = new ProxyImage();
            image.Display();
            System.Console.WriteLine("Image Display Completely!");
        }
    }
}
