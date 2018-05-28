namespace VisitorDesignPattern
{
    public class Success : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            System.Console.WriteLine("{0} {1}时，背后多半有一个伟大的女人。", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            System.Console.WriteLine("{0} {1}时，背后大多有一个不成功的男人。", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}