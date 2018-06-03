namespace BuilderDesignPattern
{
    public class ColdDrink : IFoodItem
    {
        private string _name;
        public string Name
        {
            get { return _name; }
        }

        public IPacking Packing
        {
            get { return new Bottle(); }
        }
        private float _price;
        public float Price
        {
            get { return _price; }
        }

        public ColdDrink(string name, float price)
        {
            _name = name;
            _price = price;
        }
    }
}