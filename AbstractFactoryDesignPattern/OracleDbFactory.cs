namespace AbstractFactoryDesignPattern
{
    public class OracleDbFactory : IDbFactory
    {
        public IOperateDepartment CreateOperateDepartment()
        {
            return new OracleOperateDepartment();
        }

        public IOperateUser CreateOperateUser()
        {
            throw new System.NotImplementedException();
        }
    }
}