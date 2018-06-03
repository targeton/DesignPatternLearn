namespace BuilderDesignPattern
{
    public class ConcreteMealBuilder2 : MealBuilder
    {
        public override void PrepareDrinks()
        {
            _meal.Add(new ColdDrink("可口可乐", 8.0f));
            _meal.Add(new ColdDrink("咖啡", 12.0f));
        }

        public override void PrepareFoods()
        {
            _meal.Add(new Burger("巨无霸", 13.0f));
        }
    }
}