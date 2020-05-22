using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一维数组的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Name = { "张三", "李四", "王五" };
            //Console.WriteLine(Name[0]); //数组元素的输出

            //给数组元素重新赋值
            /*
                Name[0] = "赵六";
                Console.WriteLine(Name[0]);
            */

            //数组中遍历元素，即对数组中的所有元素都按次序访问仅一次
            //利用for循环实现
            /*
               for(int i = 0; i < 3;i++)
                {
                    Console.WriteLine(Name[i]);
                }
             */
            
            //利用foreach语句实现遍历
            foreach(string MyString in Name)
            {
                Console.WriteLine(MyString);
            }

            Console.ReadKey();
        }
    }
}
