using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5属性的使用02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cleark LG = new Cleark();
            LG._Name = "张三";
            LG.Age = -25;
            LG.Gender = 'T';
            LG._Workyears = 5;
            LG._Department = "人力资源部";

            LG.Write();

            Console.ReadKey();
        }
    }
}
