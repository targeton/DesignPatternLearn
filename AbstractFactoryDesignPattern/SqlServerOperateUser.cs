namespace AbstractFactoryDesignPattern
{
    public class SqlServerOperateUser : IOperateUser
    {
        public User GetUser()
        {
            System.Console.WriteLine("Get a User From SqlServer Database!");
            return new User();
        }

        public bool InsertUser()
        {
            System.Console.WriteLine("Insert one User data into SqlServer Database!");
            return true;
        }
    }
}