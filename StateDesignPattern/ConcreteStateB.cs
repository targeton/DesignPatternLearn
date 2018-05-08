namespace StateDesignPattern
{
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            if (context.Hour > 12 && context.Hour <= 18)
                System.Console.WriteLine("当前时间为{0}，下午",context.Hour);
            else
            {
                context.SetState(new ConcreteStateC());
                context.Request();
            }
        }
    }
}