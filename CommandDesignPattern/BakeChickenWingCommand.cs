namespace CommandDesignPattern
{
    public class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExecuteCommand()
        {
            _receiver.BakeChickenWing();
        }
    }
}