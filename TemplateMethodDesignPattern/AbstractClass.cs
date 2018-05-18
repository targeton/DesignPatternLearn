namespace TemplateMethodDesignPattern
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            System.Console.WriteLine("具体方法实现：");
            PrimitiveOperation1();
            PrimitiveOperation2();
        }

        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
    }
}