namespace AbstractFactoryDesignPattern
{
    public interface IOperateUser
    {
        User GetUser();
        bool InsertUser();
    }   
}