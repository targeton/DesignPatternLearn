namespace AbstractFactoryDesignPattern
{
    public class SqlServerOperateDepartment : IOperateDepartment
    {
        public Department GetDepartment()
        {
            System.Console.WriteLine("Get a Department From SqlServer Database!");
            return new Department();
        }

        public bool InsertDepartment()
        {
            System.Console.WriteLine("Insert one Department data into SqlServer Database!");
            return true;
        }
    }
}