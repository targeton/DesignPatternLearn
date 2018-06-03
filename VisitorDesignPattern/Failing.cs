namespace VisitorDesignPattern
{
    public class Failing : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            System.Console.WriteLine("{0} {1}时，闷头喝酒，谁也不用劝。", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            System.Console.WriteLine("{0} {1}时，眼泪汪汪，谁也劝不了。", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}