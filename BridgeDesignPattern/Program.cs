using System;

namespace BridgeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            # 桥接模式
                将抽象部分与它的实现部分分离，使它们都可以独立地变化。提供抽象化和实现化之间的桥接结构，实现解耦。

            # 合成聚合复用原则
                尽量使用合成/聚合，尽量不要使用类继承。类集成是一种强耦合关系，父类变则子类变，而合成聚合则是一种弱耦合关系。
            
            ## 聚合
                聚合表示一种弱的“拥有”关系，体现的是A对象可以包含B对象，但B对象不是A对象的一部分。

            ## 合成
                合成表示一种强的“拥有”关系，体现了严格的部分和整体的关系，部分和整体的生命周期一样。
             */

            // 手机品牌和手机软件是一种合成关系，通过手机品牌的抽象类内的SetSoft方法将手机软件的具体关联到手机品牌
            // 如有需要，只需单独实现新的手机品牌子类和手机软件子类即可，可以很好的解耦
            HandsetSoft game = new HandsetGame();
            HandsetSoft addressList = new HandsetAddressList();

            HandsetBrand brandN = new HandsetBrandN();
            HandsetBrand brandM = new HandsetBrandM();

            brandN.SetSoft(game);
            brandN.Run();

            brandM.SetSoft(addressList);
            brandM.Run();

            brandN.SetSoft(addressList);
            brandN.Run();

            brandM.SetSoft(game);
            brandM.Run();
            
        }
    }
}
