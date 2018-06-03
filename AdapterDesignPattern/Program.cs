using System;

namespace AdapterDesignPattern
{
    class Program
    {
        // 适配器模式用于将一个类的接口转换成客户端希望的另一个接口，使得原本由于由于接口不兼容而不能一起工作的那些类可以一起工作
        // ForeignCenter类与其他继承Player的类具有相似的功能，通过Translator类将ForeignCenter转换为可通过Player进行操作
        // 适配器模式常用于工程实现的后期，为了解决接口不兼容的问题，如果早期设计足够全面，可避免使用
        static void Main(string[] args)
        {
            Player player1 = new Forwards("巴蒂尔");
            player1.Attack();
            player1.Defense();

            Player player2 = new Guards("麦迪");
            player2.Attack();
            player2.Defense();

            Player player3 = new Translator("姚明");
            player3.Attack();
            player3.Defense();
        }
    }
}
