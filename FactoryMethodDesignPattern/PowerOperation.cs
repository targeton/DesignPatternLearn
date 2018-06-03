namespace FactoryMethodDesignPattern
{
    public class PowerOperation : Operation
    {
        public override double GetResult(double num1, double num2)
        {
            return System.Math.Pow(num1, num2);
        }
    }
}