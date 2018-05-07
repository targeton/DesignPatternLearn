namespace DecorateDesignPattern
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            System.Console.WriteLine("ConcreteComponent Operation!");
        }
    }
}