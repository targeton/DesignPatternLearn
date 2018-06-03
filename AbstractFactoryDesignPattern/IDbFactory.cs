namespace AbstractFactoryDesignPattern
{
    public interface IDbFactory
    {
        IOperateUser CreateOperateUser();
        IOperateDepartment CreateOperateDepartment();
    }
}