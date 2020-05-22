using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串的长度获取
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串名称.Length
            //返回类型：int
            //注意事项：返回的是一个实例中char对象的个数，而不是Unicode的字符个数
            Console.WriteLine("=========获取字符串的长度=========");
            string MyStr = Console.ReadLine();
            int StringNumber = 0;
            for (int i = 0; i < MyStr.Length;i++)
            {
                Console.Write(MyStr.Substring(i,1)+"\t");
                StringNumber = StringNumber + 1;
            }
            Console.WriteLine("\n当前字符数量为:" + StringNumber);

            Console.ReadKey();
        }
    }
}
