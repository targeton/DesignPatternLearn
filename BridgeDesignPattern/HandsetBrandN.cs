namespace BridgeDesignPattern
{
    public class HandsetBrandN : HandsetBrand
    {
        public override void Run()
        {
            System.Console.WriteLine("N 品牌手机：");
            _soft.Run();
        }
    }
}