namespace BuilderDesignPattern
{
    // 建造者类，负责构建复杂对象
    public abstract class MealBuilder
    {
        protected Meal _meal = new Meal();
        public abstract void PrepareFoods();

        public abstract void PrepareDrinks();
        public Meal Build()
        {
            return _meal;
        }
    }
}