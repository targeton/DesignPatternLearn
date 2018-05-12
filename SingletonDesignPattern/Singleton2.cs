namespace SingletonDesignPattern
{
    //线程安全的懒汉单例模式
    public class Singleton2
    {
        private static Singleton2 _instance;
        private static readonly object lock_object = new object();

        private Singleton2()
        {

        }

        // //加锁保证线程安全，每次获取实例时都需要加锁，很费性能
        // public static Singleton2 GetInstance()
        // {
        //     lock (lock_object)
        //     {
        //         if (_instance == null)
        //             _instance = new Singleton2();
        //     }
        //     return _instance;
        // }

        //双重判断，既可保获取同一实例是线程安全的，也不用一直加锁影响性能
        public static Singleton2 GetInstance()
        {
            if (_instance == null)
            {
                lock (lock_object)
                {
                    if (_instance == null)
                        _instance = new Singleton2();
                }
            }
            return _instance;
        }
    }
}