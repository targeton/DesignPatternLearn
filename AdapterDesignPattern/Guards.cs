namespace AdapterDesignPattern
{
    public class Guards : Player
    {
        public Guards(string playerName) : base(playerName)
        {
        }

        public override void Attack()
        {
            System.Console.WriteLine("后卫{0}正在进攻！", _playerName);
        }

        public override void Defense()
        {
            System.Console.WriteLine("后卫{0}正在进攻！", _playerName);
        }
    }
}