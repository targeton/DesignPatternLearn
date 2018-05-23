using System;

namespace MementoDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 备忘录模式适用于功能比较复杂，但需要维护或记录属性历史的类，或者需要保存众多属性中的一小部分时，或者需要恢复原先状态、撤销相关操作等
            // Memento类用于存储需维护或记录的属性，本例中对应RoleStateMemento类
            // Originator类作为Memento类的发起者，该类内有属性需要记录，通过创建Memento类实例来存储相关信息，也可以通过Memento实例恢复相关属性值，本例对应GameRole类
            // Caretaker类用来得到或返回Memento实例，内部可以设置集合类属性，用于记录一连串Memento实例，可供Originator类多次撤销操作，逐级返回上一状态
            // 属性细节都封装于Memento类内部，在未破坏Originator类的情况下，捕获了其状态，并封装于Memento类中，经由Caretaker类保存

            // 初始化备忘录模式中的Originator类
            GameRole role = new GameRole();
            role.GetInitState();
            role.StateDisplay();
            // 存储状态
            RoleStateCaretaker caretaker = new RoleStateCaretaker();
            caretaker.Memento = role.SaveMemento();
            // 状态变化
            role.Fight();
            role.StateDisplay();
            // 从Caretaker类中获取Memento类实例，进而恢复原始状态
            role.RecoveryState(caretaker.Memento);
            role.StateDisplay();
        }
    }
}
