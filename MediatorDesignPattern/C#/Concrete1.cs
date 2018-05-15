namespace MediatorDesignPattern.CSharp
{
    public class Concrete1
    {
        public Concrete1()
        {
            //注册消息服务
            bool success = MessageCenter.RegisterMessageService("ReceiveMessageService", new MessageHandle(HandleMessage));
        }

        public object HandleMessage(string[] messages)
        {
            foreach (var m in messages)
            {
                System.Console.WriteLine("Concrete1 Get Message: {0}", m);
            }
            return true;
        }
    }
}