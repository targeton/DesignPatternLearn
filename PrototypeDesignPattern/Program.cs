using System;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 原型模式：用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象
            // 就是从一个对象创建另一个可定制的对象，而且不需要知道任何创建的细节
            // 原型模式就是要实现Clone()方法，C#内就提供ICloneable接口，实现这个接口就可以完成原型模式
            Resume resume1 = new Resume("ZZ");
            resume1.SetPersonInfo("男", "29");
            resume1.SetWorkExperience(new DateTime(2008, 9, 4), "南理工");

            Resume resume2 = (Resume)resume1.Clone();
            resume2.SetWorkExperience(new DateTime(2012, 9, 4), "研究生");

            Resume resume3 = (Resume)resume1.Clone();
            resume3.SetWorkExperience(new DateTime(2015, 4, 7), "苏研院");

            resume1.Display();
            resume2.Display();
            resume3.Display();
        }
    }
}
