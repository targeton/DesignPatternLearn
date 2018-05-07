using System;

namespace DecorateDesignPattern
{
    public class ConcreteDecorate : Decorate
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Decorate The Component!");
        }
    }
}