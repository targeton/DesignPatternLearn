using System;
using System.Collections.Generic;

namespace CommandDesignPattern
{
    // Invoker类
    public class Waiter
    {
        // 订单集合（存放具体命令的容器）
        private IList<Command> _orders = new List<Command>();

        // 设置订单 （客户端提出请求，此处可针对请求进行控制，拒绝请求、记录请求日志等）
        public void SetOrder(Command command)
        {
            if (command is BakeChickenWingCommand)
            {
                System.Console.WriteLine("服务员：鸡翅没有了，请点其他烧烤。");
            }
            else
            {
                _orders.Add(command);
                // 日志记录（记录相关操作，以便后续操作）
                System.Console.WriteLine("增加订单："+command.ToString()+" 时间："+DateTime.Now.ToString());
            }
        }

        public void CancelOrder(Command command)
        {
            if(!_orders.Contains(command)) return;
            _orders.Remove(command);
            System.Console.WriteLine("取消订单："+command.ToString()+" 时间："+DateTime.Now.ToString());

        }

        public void Notify()
        {
            foreach (var order in _orders)
            {
                order.ExecuteCommand();
            }
        }
    }
}