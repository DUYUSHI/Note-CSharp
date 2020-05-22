using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7数组排序
{
    class Program
    {
        static void Main(string[] args)
        {
            /*数组排序
             * Aray提供两种方法：
             *      1、Array.Sort(数组)
             *      Sort:正序排序（升序）
             *      2、Array.Reverse(数组)
             *      Reverse:倒序排序（降序）
             */

            int[] MyIntArray = { 3, 2, 4, 1, 5, 6, 8, 9,34,123,421,43,1,6,7,1,78,8,5,3,45,97 };

            //Array.Sort  
            Array.Sort(MyIntArray);
            foreach(int MyInt in MyIntArray)
            {
                Console.WriteLine(MyInt);
            }

            Console.WriteLine("=============分割条==============");

            //Array.Reverse
            Array.Reverse(MyIntArray);
            foreach(int MyInt in MyIntArray)
            {
                Console.WriteLine(MyInt);
            }

            Console.ReadKey();
        }
    }
}
