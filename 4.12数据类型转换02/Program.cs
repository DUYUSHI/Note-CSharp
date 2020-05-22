using System;

using pt = System.Console;

namespace 数据类型转换02
{
    class Program
    {
        static void Main(string[] args)
        {
            //强制括号转换只能转换数值类型

            string mystr = "123456";
            string StrResult;
            int myint = 100;
            int IntResult;
            //string -> int
            //(int)此方法不适用于将string转换为int，只能转换数值类型int,而不能转换引用类型
            /**
             * IntResult = (int)mystr;
             * pt.WriteLine(IntResult);
             **/

            //Convert.ToInt32()     此命令会将NULL(空值)转换为0
            /**
             * IntResult = Convert.ToInt32(mystr);
             * pt.WriteLine(IntResult);
             **/

            //int.Pares()       此命令不能转换控空值
            /**
             *IntResult = int.Parse(mystr);
             *pt.WriteLine(IntResult);
             */


            pt.ReadKey();
        }
    }
}
