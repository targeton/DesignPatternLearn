namespace VisitorDesignPattern
{
    public abstract class Person
    {
        public abstract void Accept(Action visitor);
    }
}