using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二维数组的声明
{
    class Program
    {
        static void Main(string[] args)
        {
            /*声明格式：数据类型[索引,索引] <数组名称>
             * 初始化两种方式：
             *      1、new关键字
             *      2、字面值初始化
             */

            //初始化方法一：指定字面值
            string[,] FriendName = { { "张三" ,"男"},{ "李四" ,"女"}, { "王五" ,"男"}, { "赵六" ,"女"}, { "刘七" ,"男"} };

            //初始化方法二：new关键字
            //适用于元素内容未知的情况
            string[,] FriendNameNew = new string[5,2];

            //方法三：以上两种合并
            string[,] _FriendNameNew_1 =new string [,] { { "张三", "男" }, { "李四", "女" }, { "王五", "男" }, { "赵六", "女" }, { "刘七", "男" } };

            Console.ReadKey();
        }
    }
}
