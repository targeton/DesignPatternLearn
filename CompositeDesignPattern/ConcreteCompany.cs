using System.Collections.Generic;

namespace CompositeDesignPattern
{
    public class ConcreteCompany : Company
    {
        private List<Company> _children = new List<Company>();
        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company c)
        {
            _children.Add(c);
        }

        public override void Display(int depth)
        {
            System.Console.WriteLine(new string('-', depth) + _name);
            foreach (var item in _children)
            {
                item.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (var item in _children)
            {
                item.LineOfDuty();
            }
        }

        public override void Remove(Company c)
        {
            _children.Remove(c);
        }
    }
}