namespace BuilderDesignPattern
{
    public interface IFoodItem
    {
        string Name { get; }
        IPacking Packing { get; }
        float Price { get; }
    }
}