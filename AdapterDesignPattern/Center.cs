namespace AdapterDesignPattern
{
    public class Center : Player
    {
        public Center(string playerName) : base(playerName)
        {
        }

        public override void Attack()
        {
            System.Console.WriteLine("中锋{0}正在进攻！", _playerName);
        }

        public override void Defense()
        {
            System.Console.WriteLine("中锋{0}正在进攻！", _playerName);
        }
    }
}