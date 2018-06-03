namespace NullObjectDesignPattern
{
    public abstract class AbstractCustomer
    {
        protected string _name;
        public abstract bool IsNull();
        public abstract string GetName();
    }
}