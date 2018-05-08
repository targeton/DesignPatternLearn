namespace StateDesignPattern
{
    public class Context
    {
        private State _state;
        private int _hour;
        public int Hour
        {
            get { return _hour;}
            set { _hour = value;}
        }
        
        public void SetState(State state)
        {
            _state = state;
        }

        public void Request()
        {
            if (_state != null)
                _state.Handle(this);
        }
    }
}