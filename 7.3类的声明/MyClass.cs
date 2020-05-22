using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3类的声明
{
    public enum Gender
    {
        男,
        女
    }
    class MyClass
    {
        //方法中可以存放字段，可以存放属性，还可以存放方法
        //一般在结构或类声明的变量，都叫做一个字段
        //字段，可以存放多个值，变量只能存储一个值
        //字段，命名规范，_camelCase
        public string _Name;
        public Gender _Gender;
        public int _Age;
        public string _Department;
        public int _WorkYears;

        //静态方法只能调用静态成员
        //非静态方法可以调用任何成员

        public void Write()
        {
            Console.WriteLine("Name:{0}\n性别:{1}\n年龄:{2}\n部门:{3}\n工龄:{4}",_Name,_Gender,_Age, _Department, _WorkYears);
        }
    }
}
