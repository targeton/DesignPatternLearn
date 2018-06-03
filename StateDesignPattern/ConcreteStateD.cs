namespace StateDesignPattern
{
    public class ConcreteStateD : State
    {
        public override void Handle(Context context)
        {
            if (context.Hour > 0 && context.Hour <= 6)
                System.Console.WriteLine("当前时间为{0}，凌晨", context.Hour);
            else
                System.Console.WriteLine("当前时间为{0}，不知状态", context.Hour);
        }
    }
}