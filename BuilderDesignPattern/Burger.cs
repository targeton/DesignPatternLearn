namespace BuilderDesignPattern
{
    public class Burger : IFoodItem
    {
        private string _name;
        public string Name
        {
            get { return _name; }
        }

        public IPacking Packing
        {
            get { return new Wrapper(); }
        }
        private float _price;
        public float Price
        {
            get { return _price; }
        }

        public Burger(string name, float price)
        {
            _name = name;
            _price = price;
        }
    }
}