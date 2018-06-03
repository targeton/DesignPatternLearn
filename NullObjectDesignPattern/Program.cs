using System;

namespace NullObjectDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            # 空对象模式
                空对象设计模式主要为了解决空异常，避免客户端的空判断
             */
            AbstractCustomer customer1 = CustomerFactory.GetCustomer("Bob");
            AbstractCustomer customer2 = CustomerFactory.GetCustomer("Rob");
            AbstractCustomer customer3 = CustomerFactory.GetCustomer("Julie");
            AbstractCustomer customer4 = CustomerFactory.GetCustomer("Laura");
            System.Console.WriteLine("Customers:");
            System.Console.WriteLine(customer1.GetName());
            System.Console.WriteLine(customer2.GetName());
            System.Console.WriteLine(customer3.GetName());
            System.Console.WriteLine(customer4.GetName());
        }
    }
}
