namespace AbstractFactoryDesignPattern
{
    // //利用简单工厂方式将创建工厂的实现放置于当前类内，使客户端与具体工程类的创建分离，不过有新的实现时则需要更改当前类    
    // public class DbAccess
    // {
    //     private static readonly string databaseType = "Oracle";

    //     public static IOperateUser CreateOperateUser()
    //     {
    //         IOperateUser result = null;
    //         switch (databaseType)
    //         {
    //             case "Oracle":
    //                 result = new OracleOperateUser();
    //                 break;
    //             case "SqlServer":
    //                 result = new SqlServerOperateUser();
    //                 break;
    //         }
    //         return result;
    //     }

    //     public static IOperateDepartment CreateOperateDepartment()
    //     {
    //         IOperateDepartment result = null;
    //         switch (databaseType)
    //         {
    //             case "Oracle":
    //                 result = new OracleOperateDepartment();
    //                 break;
    //             case "SqlServer":
    //                 result = new SqlServerOperateDepartment();
    //                 break;
    //         }
    //         return result;
    //     }

    // }

    //使用反射方式创建对象，当需要扩展实现时可以避免更改当前类，具体的实现可移至配置文件
    public class DbAccess
    {
        private static readonly string operateUserNamespace = "AbstractFactoryDesignPattern.OracleOperateUser";
        private static readonly string operateDepartmentNamespace = "AbstractFactoryDesignPattern.OracleOperateDepartment";

        public static IOperateUser CreateOperateUser()
        {
            return (IOperateUser)System.Reflection.Assembly.GetAssembly(typeof(DbAccess)).CreateInstance(operateUserNamespace);
        }

        public static IOperateDepartment CreateOperateDepartment()
        {
            return (IOperateDepartment)System.Reflection.Assembly.GetAssembly(typeof(DbAccess)).CreateInstance(operateDepartmentNamespace);
        }
    }
}