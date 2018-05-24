using System;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            # 组合模式
                将对象组合成树形结构以表示‘部分-整体’的层次结构，使得用户对单个对象和组合对象的使用具有一致性。
                组合模式分为透明方式和安全方式。
            
            ## 透明方式
                在Component基类中声明所有管理子对象的方法，包括Add，Remove等方法，所有继承Component的子类，
                无论树枝类还是叶节点类都将具备相关方法，其实叶节点无需实现这些方法，
                透明方式的好处就在于叶节点和树枝对外是一致的，利于操作。
            
            ## 安全方式
                在Component基类中不去声明管理子对象的方法，那么树叶类（Leaf类）也就不需要实现相关管理子类的方法，
                而是在树枝类（Composite类）中声明所有管理子对象的方法，这样可以确保树叶类和树枝类功能明确，不易误操作。
                不过树叶类和树枝类将不具有相同的接口，客户端在调用时需做出判断，带来了不便。
             */
            
            // 样例演示的是采用透明方式的组合模式
            Company root = new ConcreteCompany("总公司");
            Company rootHR = new HRDepartment("总公司人事部");
            Company rootF = new FinanceDepartment("总公司财务部");
            root.Add(rootHR);
            root.Add(rootF);

            Company c1 = new ConcreteCompany("华东分公司");
            Company c1HR = new HRDepartment("华东分公司人事部");
            Company c1F = new FinanceDepartment("华东分公司财务部");
            c1.Add(c1HR);
            c1.Add(c1F);
            root.Add(c1);

            Company c2 = new ConcreteCompany("南京办事处");
            Company c2HR = new HRDepartment("南京办事处人事部");
            Company c2F = new FinanceDepartment("南京办事处财务部");
            c2.Add(c2HR);
            c2.Add(c2F);
            c1.Add(c2);

            Company c3 = new ConcreteCompany("杭州办事处");
            Company c3HR = new HRDepartment("杭州办事处人事部");
            Company c3F = new FinanceDepartment("杭州办事处财务部");
            c3.Add(c3HR);
            c3.Add(c3F);
            c1.Add(c3);

            root.Display(1);
            root.LineOfDuty();
        }
    }
}
