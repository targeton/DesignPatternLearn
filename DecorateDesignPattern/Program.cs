using System;

namespace DecorateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent component = new ConcreteComponent();
            ConcreteDecorate decorate = new ConcreteDecorate();
            decorate.SetComponent(component);
            decorate.Operation();
        }
    }
}
