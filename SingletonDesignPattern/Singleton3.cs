namespace SingletonDesignPattern
{
    //饥汉式单例模式，第一次引用类的任何成员时即初始化实例，不用延迟初始化
    //sealed关键字用于阻止派生，派生类可能会增加实例，不能保证实例的单一性
    public sealed class Singleton3
    {
        private static readonly Singleton3 _instance = new Singleton3();

        private Singleton3() { }

        public static Singleton3 GetInstance()
        {
            return _instance;
        }
    }
}