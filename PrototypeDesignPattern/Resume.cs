using System;

namespace PrototypeDesignPattern
{
    public class Resume : ICloneable
    {

        private string m_name;
        public string Name
        {
            set { m_name = value; }
            get { return m_name; }
        }

        private string m_sex;
        public string Sex
        {
            set { m_sex = value; }
            get { return m_sex; }
        }

        private string m_age;
        public string Age
        {
            set { m_age = value; }
            get { return m_age; }
        }

        private WorkExperience m_experience;
        public WorkExperience experience
        {
            set { m_experience = value; }
            get { return m_experience; }
        }

        public Resume(string name)
        {
            m_name = name;
            m_experience = new WorkExperience();
        }

        public void SetPersonInfo(string sex, string age)
        {
            m_sex = sex;
            m_age = age;
        }

        public void SetWorkExperience(DateTime workDate, string company)
        {
            m_experience.WorkDate = workDate;
            m_experience.Company = company;
        }

        private Resume(WorkExperience experience)
        {
            m_experience = (WorkExperience)experience.Clone();
        }
        public void Display()
        {
            System.Console.WriteLine("{0}:sex is {1}, age is {2}, workexperience:{3} {4}", m_name, m_sex, m_age, m_experience.WorkDate, m_experience.Company);
        }

        //实现了深复制
        public object Clone()
        {
            Resume obj = new Resume(m_experience);
            obj.Name = m_name;
            obj.Sex = m_sex;
            obj.Age = m_age;
            return obj;
        }
    }
}