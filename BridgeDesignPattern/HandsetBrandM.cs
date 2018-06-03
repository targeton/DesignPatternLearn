namespace BridgeDesignPattern
{
    public class HandsetBrandM : HandsetBrand
    {
        public override void Run()
        {
            System.Console.WriteLine("M 品牌手机：");
            _soft.Run();
        }
    }
}