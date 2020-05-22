using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Array = System.Array;

namespace _5._5遍历数组
{
    class Program
    {
        static void Main(string[] args)
        {
            /*C#数组是由System.Array类派生而来的引用对象，可使用Array类的属性来对数组进行各种操作
             * Array属性：
             *      1、命令格式：字符串名称.Length
             *      Length:获取数组总元素的个数，用来确定数组有多少个元素
             *      2、命令格式：字符串名称.GetLowerBound()
             *      GetLowerBound:获取数组中指定维度的下限
             *      3、命令格式：字符串名称.GetUpperBound()
             *      GetUpperBound:获取数组中指定维度的上限
             */

            string[,] FriendName = { { "张三", "女" }, { "李四", "男" }, { "王五", "女" }, { "赵六", "男" }, { "刘七", "女" } };

            //正序输出
            /*
                for(int i = 0; i < 5; i++)
                {
                    Console.Write(FriendName[i,0] + " | " + FriendName[i,1]+"\n");
                }
            */

            //倒序输出
            /*
                for (int i = 4; i >= 0; i--)
                {
                    Console.Write(FriendName[i, 0] + " | " + FriendName[i, 1] + "\n");
                }
            */

            //属性：Length
            Console.WriteLine(FriendName.Length);

            //属性：GetLowerBound
            Console.WriteLine(FriendName.GetLowerBound(0));

            //属性：GetUpperBound
            Console.WriteLine(FriendName.GetUpperBound(1));

            //查看元素：GetValue
            Console.WriteLine(FriendName.GetValue(0,1));

            Console.ReadKey();
        }
    }
}
