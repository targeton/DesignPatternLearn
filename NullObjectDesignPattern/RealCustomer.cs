namespace NullObjectDesignPattern
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            _name = name;
        }
        public override string GetName()
        {
            return _name;
        }

        public override bool IsNull()
        {
            return false;
        }
    }
}