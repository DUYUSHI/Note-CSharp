using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._9小结实例任务
{
    class Program
    {
        //乘法表的实现
       static void Multiple(int Num)
        {
            Console.WriteLine("您输入的乘法表数字：{0}",Num);
            for(int i = 1; i <= Num; i++)
            {
                if (Num % i != 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("{0}X{1}={2}",i,Num/i,Num );
                }
            }
        }

        //加发表的实现
        static void Add(int Num)
        {
            Console.WriteLine("您输入的假发表数字：{0}",Num);
            for(int i = 1; i <= Num; i++)
            {
                Console.WriteLine("{0}+{1}={2}", i, Num - i, Num);
            }
        }
        static void Main(string[] args)
        {
            //实现用户输入数字的加法表和乘法表的输出

            Console.Write("请输入一个数字:");
            int Num = Convert.ToInt32(Console.ReadLine());
            Multiple(Num);
            Console.WriteLine();
            Add(Num);

            Console.ReadKey();
        }
    }
}
