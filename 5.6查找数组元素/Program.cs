using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._6查找数组元素
{
    class Program
    {
        static void Main(string[] args)
        {
            //查看数组是否存在某个元素
            //获取已知存在元素的索引值
            /*Array方法：
             *      IndexOf:查找元素首次出现的位置，位置索引从0开始，未找到返回一个负数
             *      LastIndexOf:查找元素最后一次出现的位置,位置索引从0开始，未找到返回一个负数
             *      BinarySearch:查找元素收哦此出现的索引值，采用二分查找的方法
             *      ConTains:
             */
            string[,] FriendName = { { "张三", "女" }, { "李四", "男" }, { "王五", "女" }, { "赵六", "男" }, { "刘七", "女" } };
            int[] MyIntArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7 };

            int Result;
            //IndexOf(需要查找的数组,需要查找的元素)
            Result = Array.IndexOf(MyIntArray,8);
            Console.WriteLine(Result);  //输出元素所在位置索引

            //LastIndexOf(需要查找的数组,需要查找的元素)
            Result = Array.LastIndexOf(MyIntArray, 5);
            Console.WriteLine(Result);  //输出元素所在位置索引

            //BinarySearch(需要查找的数组,需要查找的元素)
            Result = Array.BinarySearch(MyIntArray, 5);
            Console.WriteLine(Result);  //输出元素所在位置索引

            //ConTains
            //Array.ConTains方法实际是对Linst接口中方法的实现，因此使用前需要将数组转换给该对象
            //转换格式：((System.Collections.IList)MyIntArray).Contains(元素值);
            bool MyBool;
            MyBool = ((System.Collections.IList)MyIntArray).Contains(5);
            if (MyBool)
            {
                Console.WriteLine("该指定元素存在");
            }
            else
            {
                Console.WriteLine("该指定元素不存在");
            }

            Console.ReadKey();
        }
    }
}
