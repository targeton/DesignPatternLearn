namespace MediatorDesignPattern.Normal
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            System.Console.WriteLine("Colleague2 Get Message: {0}", message);
        }
    }
}