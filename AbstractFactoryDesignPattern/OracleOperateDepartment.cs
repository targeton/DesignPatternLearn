namespace AbstractFactoryDesignPattern
{
    public class OracleOperateDepartment : IOperateDepartment
    {
        public Department GetDepartment()
        {
            System.Console.WriteLine("Get a Department From Oracle Database!");
            return new Department();
        }

        public bool InsertDepartment()
        {
            System.Console.WriteLine("Insert one Department data into Oralce Database!");
            return true;
        }
    }
}