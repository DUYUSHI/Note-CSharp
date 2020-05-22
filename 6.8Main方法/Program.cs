using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._8Main方法
{
    class Program
    {
        /* Main方法有四种表现形式：
         *  1、Public static void Main()
         *  2、Public static int Main()
         *  3、Public static void Main(string[] args)
         *  4、Public static int Main(string[] args)
         */
        static void Main(string[] args)
        {
            /* Main方法：程序的入口点，也是结束点
             */

            Console.WriteLine("{0}",args.Length);
            foreach(string OutStr in args)
            {
                Console.WriteLine(OutStr);
            }

            Console.ReadKey();
        }
    }
}
