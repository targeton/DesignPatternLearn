namespace BuilderDesignPattern
{
    public class ConcreteMealBuilder1 : MealBuilder
    {
        public override void PrepareDrinks()
        {
            _meal.Add(new ColdDrink("可口可乐", 8.0f));
        }

        public override void PrepareFoods()
        {
            _meal.Add(new Burger("麦辣鸡", 9.0f));
            _meal.Add(new Burger("巨无霸", 13.0f));
        }
    }
}