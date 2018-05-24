namespace CompositeDesignPattern
{
    // 树叶节点，不实现子对象管理方法（Add、Remove等）
    public class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name)
        {
        }

        public override void Add(Company c)
        {

        }

        public override void Display(int depth)
        {
            System.Console.WriteLine(new string('-', depth) + _name);
        }

        public override void LineOfDuty()
        {
            System.Console.WriteLine("{0} 员工招聘管理", _name);
        }

        public override void Remove(Company c)
        {

        }
    }
}