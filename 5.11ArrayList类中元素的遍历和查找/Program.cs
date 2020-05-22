using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//引入命名空间
using System.Collections;

namespace _5._11ArrayList类中元素的遍历和查找
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList类
             *       foreach语句，Object类型
             *       Object:ArrayList中存储的类型不一定一直，也不一定足够完全自动转换，所以为避免出错，我们采用Object类型
             */

            /* 元素查找三种方法：
             *         1、IndexOf(需要查找的元素)，返回一个索引值，未找到返回负数
             *         2、LastIndexOf(需要查找的元素)，返回一个索引值，未找到返回负数
             *         3、BinarySearch(需要查找的元素),未查找到返回-1
             */

            ArrayList MyArrayList = new ArrayList();
            MyArrayList.Add("数字：");
            int[] MyIntArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            MyArrayList.AddRange(MyIntArray);
            MyArrayList.Add("字符串：");
            string[] MyStringArray = { "张三", "李四", "王五", "赵六" };
            MyArrayList.AddRange(MyStringArray);

            //元素数组遍历
            foreach (object MyObject in MyArrayList)
            {
                Console.Write(MyObject + "\t");
            }
            Console.WriteLine();

            //元素数组查找
            //IndexOf(需要查找的元素)
            Console.WriteLine(MyArrayList.IndexOf("张三"));

            //LastIndexOf(需要查找的元素)
            Console.WriteLine(MyArrayList.LastIndexOf(5));

            //BinarSearch(需要查找的元素)
            //Console.WriteLine(MyArrayList.BinarySearch("李四"));
            ArrayList NewAL = new ArrayList();
            NewAL.AddRange(MyIntArray);
            Console.WriteLine(NewAL.BinarySearch(5));

            Console.ReadKey();
        }
    }
}
