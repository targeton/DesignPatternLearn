using System;

namespace SimpleFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            double opera1, opera2;
            while (true)
            {
                Console.WriteLine("Please enter a number:");
                if (double.TryParse(Console.ReadLine(), out opera1))
                    break;
            }
            while (true)
            {
                Console.WriteLine("Please enter another number:");
                if (double.TryParse(Console.ReadLine(), out opera2))
                    break;
            }
            Console.WriteLine("Please enter operator(+,-,*,/):");
            string operate = Console.ReadLine();
            Operation operation = OperationFactory.CreateOperation(operate);
            if (operation == null)
                Console.WriteLine("Illegal input!");
            System.Console.WriteLine("The result is:{0}", operation.GetResult(opera1, opera2));
        }
    }
}
