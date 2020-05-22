using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._9类的封装
{
    public enum Gender
    {
        男,
        女,
    }
    public class ClassLei01
    {
        //类成员默认为private，一般我们为便于识别，认为在前面加上private，加与不加意义一样
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private Gender _gender;
        public Gender GD
        {
            get { return _gender; }
            set { _gender = value; }
        }

        //受保护，只能在当前类内部及子类中访问
        //protected string MyText;    //允许在当前类和派生类中进行访问与调用

        //在类中编写一个方法
        public void ClassLei01Write()
        {
            Console.WriteLine("{0},{1},{2}", this.Name, this.Age, this.GD);
        }

        //编译构造函数
        public ClassLei01(string name,int age,Gender gd)
        {
            this.Name = name;
            this.Age = age;
            this.GD = gd;

            //测试是否可以在子类中访问protected字段
            //this.MyText = "受保护的字段，可以在子类中访问";
        }
    }
}
