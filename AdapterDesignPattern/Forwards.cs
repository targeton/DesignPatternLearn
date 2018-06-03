namespace AdapterDesignPattern
{
    public class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {

        }

        public override void Attack()
        {
            System.Console.WriteLine("前锋{0}正在进攻！", _playerName);
        }

        public override void Defense()
        {
            System.Console.WriteLine("前锋{0}正在防守！", _playerName);
        }
    }
}