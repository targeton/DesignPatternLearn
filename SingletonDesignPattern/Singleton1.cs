namespace SingletonDesignPattern
{
    //采用懒汉式单例模式，延迟实例化的时间，当前类的实例是线程不安全的
    public class Singleton1
    {
        private static Singleton1 _instance;

        /*设定私有构造方法，禁止外部通过new方式创建实例 */
        private Singleton1()
        {

        }

        public static Singleton1 GetInstance()
        {
            if (_instance == null)
                _instance = new Singleton1();
            return _instance;
        }

    }
}