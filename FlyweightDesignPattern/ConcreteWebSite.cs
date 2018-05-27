namespace FlyweightDesignPattern
{
    public class ConcreteWebSite : WebSite
    {
        private string _name = "";
        public ConcreteWebSite(string name)
        {
            _name = name;
        }

        public override void Use()
        {
            System.Console.WriteLine("网站分类：" + _name);
        }
    }
}