namespace AbstractFactoryDesignPattern
{
    public interface IOperateDepartment
    {
        Department GetDepartment();
        bool InsertDepartment();    
    }
}