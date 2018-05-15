using System.Collections.Generic;

namespace MediatorDesignPattern.CSharp
{
    public delegate object MessageHandle(string[] messages);
    public class MessageCenter
    {
        private static IDictionary<string, MessageHandle> _messageDictionary;

        static MessageCenter()
        {
            _messageDictionary = new Dictionary<string, MessageHandle>();
        }

        public static bool RegisterMessageService(string serviceName, MessageHandle handle)
        {
            if (_messageDictionary.ContainsKey(serviceName))
                return false;
            else
            {
                _messageDictionary.Add(serviceName, handle);
                return true;
            }
        }

        public static object SendMessage(string serviceName, string[] messages)
        {
            if (!_messageDictionary.ContainsKey(serviceName))
                return null;
            else
            {
                MessageHandle handle = _messageDictionary[serviceName];
                return handle(messages);
            }
        }
    }
}