using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一维数组的声明
{
    class Program
    {
        static void Main(string[] args)
        {
            /*声明规则：数据类型[] <数组名称>
             *说明:
             *      1、数据类型可以为任意数据类型
             *      2、数组访问之前必须初始化
             *      3、初始化方式有两种：
             *          1、new关键字
             *          2、字面值逗号相隔指定
             */
             //用于已经变量数组内容的声明
            int[] MyIntArray = { 2,3,1,4,5,1,2,3,7,8};
            Console.WriteLine(MyIntArray[1]);

            //初始化数组
            //用于未知数组各元素值的一个声明，指定数组长度
            //string[] MyStringArray = { "Y","Z","M" };
            string[] MyStringArray = new string[] { "Y", "Z", "M" };
            Console.WriteLine(MyStringArray[1]);

            //元素个数与数组长度必须一一对应
            string[] NameArray = new string[3] { "张三", "李四", "王五" };
            Console.WriteLine(NameArray[1]);

            //先初始化数组，然后对数组元素进行赋值
            string[] DebugArray = new string[3];
            DebugArray[1] = "YuZMboy";
            Console.WriteLine(DebugArray[1]);

            Console.ReadKey();
        }
    }
}
