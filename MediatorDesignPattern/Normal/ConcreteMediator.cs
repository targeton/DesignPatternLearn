namespace MediatorDesignPattern.Normal
{
    public class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 _colleague1;
        public ConcreteColleague1 Colleague1
        {
            set { _colleague1 = value;}
        }
        
        private ConcreteColleague2 _colleague2;
        public ConcreteColleague2 Colleague2
        {
            get { return _colleague2;}
            set { _colleague2 = value;}
        }

        public override void Send(string message, Colleague colleague)
        {
            if(colleague == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else
            {
                _colleague1.Notify(message);
            }
        }
    }
}