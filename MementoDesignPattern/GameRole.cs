using System;

namespace MementoDesignPattern
{
    public class GameRole
    {
        private int _vitality;
        private int _attack;
        private int _defense;

        public RoleStateMemento SaveMemento()
        {
            return new RoleStateMemento()
            {
                Vitality = _vitality,
                Attack = _attack,
                Defense = _defense
            };
        }

        public void RecoveryState(RoleStateMemento memento)
        {
            _vitality = memento.Vitality;
            _attack = memento.Attack;
            _defense = memento.Defense;
        }

        public void GetInitState()
        {
            _vitality = 100;
            _attack = 100;
            _defense = 100;
        }

        public void Fight()
        {
            System.Console.WriteLine("GameRole Fighting...");
            Random rand = new Random();
            _vitality -= rand.Next(100);
            _attack -= rand.Next(100);
            _defense -= rand.Next(100);
        }

        public void StateDisplay()
        {
            System.Console.WriteLine("Now State: Vitality {0}, Attack {1}, Defense {2}", _vitality, _attack, _defense);
        }
    }
}