using System.Linq;

namespace NullObjectDesignPattern
{
    public class CustomerFactory
    {
        public static string[] _names = new string[] { "Rob", "Joe", "Julie" };
        public static AbstractCustomer GetCustomer(string name)
        {
            if (_names.Contains(name))
                return new RealCustomer(name);
            else
                return new NullCustomer();
        }
    }
}