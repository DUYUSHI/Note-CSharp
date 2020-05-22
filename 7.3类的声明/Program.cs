using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3类的声明
{


    class Program
    {
        static void Main(string[] args)
        {
            //将类实例化，就是将类指定个某个对象
            MyClass LG = new MyClass();
            LG._Name = "张三";
            LG._Gender = Gender.男;
            LG._Department = "人力资源部";
            LG._Age = 25;
            LG._WorkYears = 5;

            LG.Write();

            Console.ReadKey();
        }
    }
}

