using System;

namespace StrategyDesignPattern
{
    public class ConcreteStrategy1 : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine("This is ConcreteStrategy1!");            
        }
    }
}