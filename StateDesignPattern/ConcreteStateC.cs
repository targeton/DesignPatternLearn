namespace StateDesignPattern
{
    public class ConcreteStateC : State
    {
        public override void Handle(Context context)
        {
            if (context.Hour > 18 && context.Hour < 24)
                System.Console.WriteLine("当前时间为{0}，晚上", context.Hour);
            else
            {
                context.SetState(new ConcreteStateD());
                context.Request();
            }
        }
    }
}