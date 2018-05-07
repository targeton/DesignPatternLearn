using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {         
            Context context;
            Console.WriteLine("Please Enter Number 1-3 To Choose Algorithm:");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    context = new Context(new ConcreteStrategy1());
                    break;
                case "2":
                    context = new Context(new ConcreteStrategy2());
                    break;
                case "3":
                default:
                    context = new Context(new ConcreteStrategy3());
                    break;
            }
            context.ImplementAlgorithm();
        }
    }
}
