using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//引入命名空间
using _7._9类的封装;

namespace MyTextProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //引用7.9节项目
            
            //引用ClassLei02类
            ClassLei02 CL = new ClassLei02("张三", 24, Gender.女, "信息工程系");

            Console.ReadKey();
        }
    }
}
