using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7构造函数和析构函数02
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
            Console.WriteLine("{0},{1},{2},{3}", this.Name, this.GenderT, this.Age, this.Department);
        }

        //编写一个构造函数
        public ClassLei(string name, Gender gender, int age, string department)
        {
            this.Name = name;
            this.GenderT = gender;
            this.Age = age;
            this.Department = department;
        }

        //再次编写一个构造函数
        public ClassLei(string name,Gender gender,int age)
        {
            this.Name = name;
            this.GenderT = gender;
            this.Age = age;
        }

        //类当中会有一个默认的无参数的构造函数，当写一个新的构造函数之后(有参或无参)，默认的无参数的构造函数会被覆盖掉
        //我们可以手动将其无参构造函数补回来即可
        public ClassLei()
        {

        }

        //编写一个析构函数
        //如果系统中没有指定析构函数，那么编译器由GC来决定什么时候进行释放资源
        //Garbage Collection
        ~ClassLei(){
            Console.WriteLine("这是一个析构函数！");
        }
    }
}
