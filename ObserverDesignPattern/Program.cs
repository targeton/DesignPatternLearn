using System;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserverA observerA1 = new ConcreteObserverA(subject, "observer1");
            ConcreteObserverA observerA2 = new ConcreteObserverA(subject, "observer2");
            subject.Attach(observerA1);
            subject.Attach(observerA2);
            subject.SubjectState = "Hello";
            subject.Notify();
            subject.SubjectState = "World";
            subject.Notify();
        }
    }
}
