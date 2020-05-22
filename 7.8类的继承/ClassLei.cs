using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._8类的继承
{
    class Clerk
    {
        //private由于是私有，不能被子类访问，只能在本类中访问
        private string _name;
        public string Name
        {
            get{ return _name;}
            set{_name = value;}
        }

        private string _department;
        public string Department
        {
            get{return _department;}
            set{_department = value;}
        }

        public void ClerkWrite()
        {
            Console.WriteLine("我是{0}的{1}",this.Department,this.Name);
        }
        
        //定义一个构造函数
        //子类中不能继承父类中的构造函数，但是会默认的调用父类中的无参的构造函数
        /* 怎么才能实现调用（两种方法）：
         * 1、在父类中再写一个无参的构造函数（在每个子类当中都哦需要进行一次构造函数的重写与各个字段的初始化）
         * 2、使用关键字base()
         */
        public Clerk(string name,string department)
        {
            this.Name = name;
            this.Department = department;
        }

        //定义一个无参的构造函数（手动）
        //public Clerk() { }
    }
}