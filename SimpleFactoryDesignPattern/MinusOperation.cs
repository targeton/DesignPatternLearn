namespace SimpleFactoryDesignPattern
{
    public class MinusOperation : Operation
    {
        public override double GetResult(double opera1, double opera2)
        {
            return opera1 - opera2;
        }
    }
}