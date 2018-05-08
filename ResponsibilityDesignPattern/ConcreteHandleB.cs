namespace ResponsibilityDesignPattern
{
    public class ConcreteHandleB : Handle
    {
        public override void HandleRequest(int request)
        {
            if (request < 100)
                System.Console.WriteLine("request value is {0}.Less than 100.In ConcreteHandleB!!!", request);
            else
            {
                if (_successor != null)
                    _successor.HandleRequest(request);
            }
        }
    }
}