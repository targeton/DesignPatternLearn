namespace FactoryMethodDesignPattern
{
    public class AddOperationFactory : IOperationFactory
    {
        public Operation CreateOperation()
        {
            return new AddOperation();        
        }
    }
}