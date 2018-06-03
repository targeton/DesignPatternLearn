namespace BridgeDesignPattern
{
    // 抽象类，SetSoft方法作为桥接模式接口，实现抽象和具体的关联
    public abstract class HandsetBrand
    {
        protected HandsetSoft _soft;
        public void SetSoft(HandsetSoft soft)
        {
            _soft = soft;
        }

        public abstract void Run();
    }
}