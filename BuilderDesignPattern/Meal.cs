using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BuilderDesignPattern
{
    // Meal类用于模拟建造者模式中的复杂对象
    public class Meal
    {
        private IList<IFoodItem> _items = new List<IFoodItem>();

        public void Add(IFoodItem item)
        {
            _items.Add(item);
        }

        public float GetCost()
        {
            return _items.Sum(i => i.Price);
        }

        public void Show()
        {
            foreach (var item in _items)
            {
                System.Console.WriteLine("Food's Name is {0}, Packing is {1}, Price is {2}", item.Name, item.Packing.Pack, item.Price);
            }
        }
    }
}