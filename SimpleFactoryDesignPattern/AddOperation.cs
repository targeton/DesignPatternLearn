namespace SimpleFactoryDesignPattern
{
    public class AddOperation : Operation
    {
        public override double GetResult(double opera1, double opera2)
        {
            return opera1 + opera2;
        }
    }
}