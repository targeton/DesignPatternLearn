using System;

namespace PrototypeDesignPattern
{
    public class WorkExperience : ICloneable
    {
        private DateTime m_workDate;
        public DateTime WorkDate
        {
            get { return m_workDate; }
            set { m_workDate = value; }
        }

        private string m_company;
        public string Company
        {
            get { return m_company; }
            set { m_company = value; }
        }

        public object Clone()
        {
            // MemberwiseClone方法实现类的浅复制(浅复制对于值类型进行逐位复制，对于引用类型，则复制引用但不复制引用的对象)
            return this.MemberwiseClone();
        }
    }
}