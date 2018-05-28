using System.Collections.Generic;

namespace VisitorDesignPattern
{
    public class ObjectStructure
    {
        private IList<Person> _elements = new List<Person>();
        
        public void Attach(Person element)
        {
            _elements.Add(element);
        }

        public void Detach(Person element)
        {
            _elements.Remove(element);
        }

        public void Display(Action visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}