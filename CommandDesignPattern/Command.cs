namespace CommandDesignPattern
{
    public abstract class Command
    {
        protected Barbecuer _receiver;
        public Command(Barbecuer receiver)
        {
            _receiver = receiver;
        }

        abstract public void ExecuteCommand();
    }
}