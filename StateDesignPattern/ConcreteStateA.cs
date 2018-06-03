namespace StateDesignPattern
{
    using System;
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            if (context.Hour > 6 && context.Hour <= 12)
                Console.WriteLine("当前时间为{0}，上午", context.Hour);
            else
            {
                context.SetState(new ConcreteStateB());
                context.Request();
            }
        }
    }
}