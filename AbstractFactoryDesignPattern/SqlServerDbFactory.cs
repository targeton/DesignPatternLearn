namespace AbstractFactoryDesignPattern
{
    public class SqlServerDbFactory : IDbFactory
    {
        public IOperateDepartment CreateOperateDepartment()
        {
            return new SqlServerOperateDepartment();
        }

        public IOperateUser CreateOperateUser()
        {
            return new SqlServerOperateUser();
        }
    }
}