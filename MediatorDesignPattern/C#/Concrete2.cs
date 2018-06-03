namespace MediatorDesignPattern.CSharp
{
    public class Concrete2
    {
        public void SendMessage(params string[] messages)
        {
            // 通过消息服务向注册服务的类发送消息
            MessageCenter.SendMessage("ReceiveMessageService", messages);
        }
    }
}