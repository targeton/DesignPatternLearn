using System.Threading;

namespace ProxyDesignPattern
{
    public class RealImage : Image
    {
        public RealImage()
        {
            System.Console.WriteLine("Load Image ...");
            Thread.Sleep(2000);
        }
        public void Display()
        {
            System.Console.WriteLine("Show Real Image!");
        }
    }
}