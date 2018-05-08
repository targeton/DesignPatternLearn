using System;
using System.Collections.Generic;

namespace ResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 12, 4, 8, 19, 101, 200, 456 };
            Handle handleA = new ConcreteHandleA();
            Handle handleB = new ConcreteHandleB();
            Handle handleC = new ConcreteHandleC();
            handleA.SetSuccessor(handleB);
            handleB.SetSuccessor(handleC);
            foreach (var l in list)
            {
                handleA.HandleRequest(l);
            }
        }
    }
}
