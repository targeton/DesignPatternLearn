namespace TemplateMethodDesignPattern
{
    public class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            System.Console.WriteLine("具体类A实现方法一");
        }

        public override void PrimitiveOperation2()
        {
            System.Console.WriteLine("具体类A实现方法二");
        }
    }
}