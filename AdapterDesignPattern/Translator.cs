namespace AdapterDesignPattern
{
    public class Translator : Player
    {
        private ForeignCenter _foreginCenter;
        public Translator(string playerName) : base(playerName)
        {
            _foreginCenter = new ForeignCenter(playerName);
        }

        public override void Attack()
        {
            _foreginCenter.进攻();
        }

        public override void Defense()
        {
            _foreginCenter.防守();
        }
    }
}