namespace FactoryMethodDesignPattern
{
    public class AddOperation : Operation
    {
        public override double GetResult(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}