namespace MementoDesignPattern
{
    // Memento类，内部属性为Originator类需记录的相关属性值
    public class RoleStateMemento
    {
        private int _vitality;
        public int Vitality
        {
            get { return _vitality;}
            set { _vitality = value;}
        }
        
        private int _attack;
        public int Attack
        {
            get { return _attack;}
            set { _attack = value;}
        }

        private int _defense;
        public int Defense
        {
            get { return _defense;}
            set { _defense = value;}
        }
        
        
    }
}