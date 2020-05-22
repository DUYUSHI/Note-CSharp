using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二位数组的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] FriendName = { { "张三", "男" }, { "李四", "女" }, { "王五", "男" }, { "赵六", "女" }, { "刘七", "男" } };
            //Console.WriteLine(FriendName[0,0] + FriendName[0,1]);

            //遍历数组：for语言方式
            /*
                for(int i = 0;i < 5;i++)
                {
                    Console.WriteLine(FriendName[i, 0] + " | " + FriendName[i, 1]);
                }
            */

            //遍历数组：foreach语句方式
            /*
                foreach(string MyString in FriendName)
                {
                    Console.WriteLine(MyString);
                }
            */

            Console.ReadKey();
        }
    }
}
