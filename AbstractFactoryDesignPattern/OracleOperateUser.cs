namespace AbstractFactoryDesignPattern
{
    public class OracleOperateUser : IOperateUser
    {
        public User GetUser()
        {
            System.Console.WriteLine("Get a User From Oracle Database!");
            return new User();
        }

        public bool InsertUser()
        {
            System.Console.WriteLine("Insert one User data into Oralce Database!");
            return true;
        }
    }
}