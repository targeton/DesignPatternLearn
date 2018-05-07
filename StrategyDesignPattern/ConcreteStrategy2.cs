using System;

namespace StrategyDesignPattern
{
    public class ConcreteStrategy2 : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine("This is ConcreteStrategy2! HaHaHa!");
        }
    }
}