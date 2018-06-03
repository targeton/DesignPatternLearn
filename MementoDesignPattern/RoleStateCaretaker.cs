namespace MementoDesignPattern
{
    // Caretaker类 存储、获取一个或一组Memento对象
    public class RoleStateCaretaker
    {
        private RoleStateMemento _memento;
        public RoleStateMemento Memento
        {
            get { return _memento;}
            set { _memento = value;}
        }
    }
}