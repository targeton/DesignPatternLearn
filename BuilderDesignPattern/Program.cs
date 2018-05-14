using System;

namespace BuilderDesignPattern
{
    class Program
    {
        // 建造者模式：将一个复杂对象的构建与它的表示相分离，复杂对象的各个部分经常面临剧烈变化，而基于各个部分的算法则相对稳定
        // 注重变与不变的分类
        static void Main(string[] args)
        {
            // 采用Director来控制Builder构建复杂对象（控制构建过程，且复杂对象的构成元素不需要让客户端知道）：
            MealDirector director = new MealDirector();
            MealBuilder builder1 = new ConcreteMealBuilder1();
            director.Construct(builder1);
            Meal meal1 = builder1.Build();
            meal1.Show();
            System.Console.WriteLine("Costs is {0}", meal1.GetCost());

            System.Console.WriteLine("*************************************");

            MealBuilder builder2 = new ConcreteMealBuilder2();
            director.Construct(builder2);
            Meal meal2 = builder2.Build();
            meal2.Show();
            System.Console.WriteLine("Costs is {0}", meal2.GetCost());

            System.Console.WriteLine("*************************************");

            // 客户端自行控制Builder构建对象（构建灵活，但将复杂对象的构成元素暴露给客户端，加大耦合性）
            CustomMealBuilder builder = new CustomMealBuilder();
            builder.AddFood(new Burger("巨无霸", 13.0f));
            Meal meal = builder.Build();
            meal.Show();
            System.Console.WriteLine("Costs is {0}", meal.GetCost());
        }
    }
}
