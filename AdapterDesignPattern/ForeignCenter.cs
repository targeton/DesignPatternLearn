namespace AdapterDesignPattern
{
    public class ForeignCenter
    {
        private string _playerName;
        public ForeignCenter(string playerName)
        {
            _playerName = playerName;
        }
        
        public void 进攻()
        {
            System.Console.WriteLine("外籍中锋{0}正在进攻！", _playerName);
        }

        public void 防守()
        {
            System.Console.WriteLine("外籍中锋{0}正在防守！", _playerName);
        }
    }
}