using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using pr = System.Console;

namespace Csharp变量
{
    class Program
    {
        static void Main(string[] args)
        {
            pr.WriteLine("C#学习变量的存储");
            int @int;
            double @double;
            string @string;
            @int = 20;
            @double = 3.14;
            @string = "这是C#中的string数据类型";
            pr.WriteLine(@int);
            pr.WriteLine(@double);
            pr.WriteLine(@string);

            pr.ReadKey();   //等待用户输入
        }
    }
}
