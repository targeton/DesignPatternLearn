namespace FactoryMethodDesignPattern
{
    public class PowerOperationFactory:IOperationFactory
    {
        public Operation CreateOperation()
        {
            return new PowerOperation();
        }
    }
}