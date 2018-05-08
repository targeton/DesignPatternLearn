namespace ObserverDesignPattern
{
    public class ConcreteObserverA : Observer
    {
        private ConcreteSubject _subject;
        private string _observerName;

        public ConcreteObserverA(ConcreteSubject subject, string observerName)
        {
            _subject = subject;
            _observerName = observerName;
        }
        public override void Update()
        {
            System.Console.WriteLine("observer {0} get subject state change, now state is {1}", _observerName, _subject.SubjectState);
        }
    }
}