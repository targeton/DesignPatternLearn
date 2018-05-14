namespace BuilderDesignPattern
{
    // 供客户端直接使用的建造者类（不通过Director类来控制建造过程，由客户端自行创建），负责构建复杂对象
    public class CustomMealBuilder
    {
        protected Meal _meal = new Meal();
        public void AddFood(IFoodItem item)
        {
            _meal.Add(item);
        }

        public void AddDrink(IFoodItem item)
        {
            _meal.Add(item);
        }
        public Meal Build()
        {
            return _meal;
        }
    }
}