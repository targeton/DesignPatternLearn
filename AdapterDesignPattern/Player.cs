namespace AdapterDesignPattern
{
    public abstract class Player
    {
        protected string _playerName;
        public Player(string playerName)
        {
            _playerName = playerName;
        }

        public abstract void Attack();
        public abstract void Defense();
    }
}