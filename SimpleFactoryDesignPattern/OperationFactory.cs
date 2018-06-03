namespace SimpleFactoryDesignPattern
{
    public class OperationFactory
    {
        public static Operation CreateOperation(string operate)
        {
            Operation operation = null;
            switch (operate)
            {
                case "+":
                    operation = new AddOperation();
                    break;
                case "-":
                    operation = new MinusOperation();
                    break;;
                case "*":
                    operation = new MultiplyOperation();
                    break;
                case "/":
                    operation = new DivideOperation();
                    break;
            }
            return operation;
        }
    }
}