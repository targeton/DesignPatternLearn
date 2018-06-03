using System;
namespace SimpleFactoryDesignPattern
{
    public class DivideOperation : Operation
    {
        public override double GetResult(double opera1, double opera2)
        {
            if (opera2 == 0.0)
                throw new ArgumentException("divisor is illegal!");
            return opera1 / opera2;
        }
    }
}