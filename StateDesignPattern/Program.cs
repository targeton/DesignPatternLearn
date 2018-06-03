using System;
using System.Collections.Generic;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            var hours = new List<int>() { 3, 7, 13, 22, 19, -1, 8 };
            foreach (var hour in hours)
            {
                context.SetState(new ConcreteStateA());
                context.Hour = hour;
                context.Request();
            }
        }
    }
}
