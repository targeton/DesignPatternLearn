namespace CommandDesignPattern
{
    public class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExecuteCommand()
        {
            _receiver.BakeMutton();
        }
    }
}