namespace ResponsibilityDesignPattern
{
    public class ConcreteHandleC : Handle
    {
        public override void HandleRequest(int request)
        {
            if (request < 1000)
                System.Console.WriteLine("request value is {0}.Less than 1000.In ConcreteHandleC $$$###", request);
            else
            {
                if (_successor != null)
                    _successor.HandleRequest(request);
            }
        }
    }
}