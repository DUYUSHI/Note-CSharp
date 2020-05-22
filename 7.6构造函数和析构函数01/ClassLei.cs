using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._6构造函数和析构函数01
{
    public enum Gender
    {
         男,
         女,
     }
    class ClassLei
    {
        public string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        private Gender _gender;
        public Gender GenderT
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }
        private string _department;
        public string Department
        {
            get
            {
                return _department;
            }

            set
            {
                _department = value;
            }
        }

        public void Write()
        {
            Console.WriteLine("{0},{1},{2},{3}",this.Name,this.GenderT,this.Age,this.Department);
        }

        //编写一个构造函数

        public ClassLei(string name,Gender gender,int age,string department)
        {
            this.Name = name;
            this.GenderT = gender;
            this.Age = age;
            this.Department = department;
        }
        

    }
}
