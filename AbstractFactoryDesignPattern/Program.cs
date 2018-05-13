using System;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // //抽象工厂：具体创建实例的过程与客户端分离，客户端只需操作相关接口及工厂接口。
            // //客户端在需要操作具体数据类时只需创建具体的工厂实现类，产品的具体操作不再需要在客户端出现。
            // //缺点在于，每次需要操作时，都需要实例化具体的工厂类。
            // IDbFactory dbFactory = new SqlServerDbFactory();
            // IOperateUser operateUser = dbFactory.CreateOperateUser();
            // IOperateDepartment operateDepartment = dbFactory.CreateOperateDepartment();
            // operateUser.GetUser();
            // operateUser.InsertUser();
            // operateDepartment.GetDepartment();
            // operateDepartment.InsertDepartment();

            //工厂的具体创造过程在DataAccess类中实现，客户端将不再涉及任何具体类的实现，如需扩展时只需创建新的相关类，以及更改DataAccess类，真正意义上的开发扩展，封闭修改
            IOperateUser operateUser = DbAccess.CreateOperateUser();
            IOperateDepartment operateDepartment = DbAccess.CreateOperateDepartment();
            operateUser.GetUser();
            operateUser.InsertUser();
            operateDepartment.GetDepartment();
            operateDepartment.InsertDepartment();
        }
    }
}
