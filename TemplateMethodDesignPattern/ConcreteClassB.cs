namespace TemplateMethodDesignPattern
{
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            System.Console.WriteLine("具体类B实现方法一");
        }

        public override void PrimitiveOperation2()
        {
            System.Console.WriteLine("具体类B实现方法二");
        }
    }
}