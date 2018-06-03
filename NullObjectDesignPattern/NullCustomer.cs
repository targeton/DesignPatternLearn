namespace NullObjectDesignPattern
{
    // 空对象类
    public class NullCustomer : AbstractCustomer
    {
        public override string GetName()
        {
            return "Not Available in Customer Database";
        }

        public override bool IsNull()
        {
            return false;
        }
    }
}