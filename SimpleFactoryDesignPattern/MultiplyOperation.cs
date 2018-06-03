namespace SimpleFactoryDesignPattern
{
    public class MultiplyOperation : Operation
    {
        public override double GetResult(double opera1, double opera2)
        {
            return opera1 * opera2;
        }
    }
}