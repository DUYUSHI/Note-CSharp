using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using prin = System.Console;

namespace Csharp常量
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 5;
            const double pi = 3.14; //定义一个常量pi
            prin.WriteLine("圆的面积:"+pi*pi*r);
            prin.WriteLine("圆的周长:"+2*pi*r);

            prin.ReadKey();
        }
    }
}
