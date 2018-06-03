namespace ProxyDesignPattern
{
    public class ProxyImage : Image
    {
        private RealImage _realImage;

        public ProxyImage()
        {
            _realImage = new RealImage();
        }
        public void Display()
        {
            _realImage.Display();
        }
    }
}