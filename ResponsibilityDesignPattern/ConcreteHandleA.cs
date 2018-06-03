namespace ResponsibilityDesignPattern
{
    public class ConcreteHandleA : Handle
    {
        public override void HandleRequest(int request)
        {
            if (request < 10)
                System.Console.WriteLine("request value is {0}.Less than 10.In ConcreteHandleA!", request);
            else
            {
                if (_successor != null)
                    _successor.HandleRequest(request);
            }
        }
    }
}