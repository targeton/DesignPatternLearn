namespace BuilderDesignPattern
{
    // Director类，控制建造类如何构造复杂对象
    public class MealDirector
    {
        public void Construct(MealBuilder builder)
        {
            builder.PrepareFoods();
            builder.PrepareDrinks();
        }
    }
}