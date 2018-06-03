namespace FacadeDesignPattern
{
    public class Facade
    {
        private SubSystemOne systemOne;
        private SubSystemTwo systemTwo;
        private SubSystemThree systemThree;
        private SubSystemFour systemFour;

        public Facade()
        {
            systemOne = new SubSystemOne();
            systemTwo = new SubSystemTwo();
            systemThree = new SubSystemThree();
            systemFour = new SubSystemFour();
        }

        public void MethodA()
        {
            System.Console.WriteLine("方法A的调用--");
            systemOne.MethodOne();
            systemThree.MethodThree();
            systemFour.MethodFour();
        }

        public void MethodB()
        {
            System.Console.WriteLine("方法B的调用--");
            systemTwo.MethodTwo();
            systemFour.MethodFour();
        }
    }
}