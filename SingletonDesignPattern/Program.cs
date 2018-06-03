using System;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ////懒汉式单例模式
            // Singleton1 single1 = Singleton1.GetInstance();
            // Singleton1 single2 = Singleton1.GetInstance();
            // System.Console.WriteLine("single1 {0} same as single2", single1 == single2 ? "is" : "is not");

            // //以下演示Singleton1对于线程是不安全的
            // Singleton1 single1 = null;
            // Singleton1 single2 = null;
            // var t1 = Task.Factory.StartNew(() => { single1 = Singleton1.GetInstance(); });
            // var t2 = Task.Factory.StartNew(() => { single2 = Singleton1.GetInstance(); });
            // var tasks = new Task[] { t1, t2 };
            // Task.WaitAll(tasks);
            // System.Console.WriteLine("single1 {0} same as single2", single1 == single2 ? "is" : "is not");

            // //以下演示线程安全的Singleton2
            // Singleton2 single1 = null;
            // Singleton2 single2 = null;
            // var t1 = Task.Factory.StartNew(() => { single1 = Singleton2.GetInstance(); });
            // var t2 = Task.Factory.StartNew(() => { single2 = Singleton2.GetInstance(); });
            // var tasks = new Task[] { t1, t2 };
            // Task.WaitAll(tasks);
            // System.Console.WriteLine("single1 {0} same as single2", s1 == s2 ? "is" : "is not");

            //饥汉式单例模式
            Singleton3 s1 = null;
            Singleton3 s2 = null;
            var t1 = Task.Factory.StartNew(() => { s1 = Singleton3.GetInstance(); });
            var t2 = Task.Factory.StartNew(() => { s2 = Singleton3.GetInstance(); });
            var tasks = new Task[] { t1, t2 };
            Task.WaitAll(tasks);
            System.Console.WriteLine("s1 {0} same as s2", s1 == s2 ? "is" : "is not");

        }
    }
}
