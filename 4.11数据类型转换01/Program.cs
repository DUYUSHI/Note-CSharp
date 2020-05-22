using System;

using pt = System.Console;
using zh = System.Convert;

namespace 数据类型转换01
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 类型转换采用两种形式：
             *  1、隐式转换
             *      系统自行的，不需要我们进行干预，也不需要我们进行额外编码
             *  2、显式转换
             */

            //Main_数据类型转换_隐式转换();
            //Main_数据类型转换_显示转换();
            Main_数据类型转换_其它转换();

            pt.ReadKey();
        }
        static void Main_数据类型转换_隐式转换()
        {
            char MyChar = 'a';
            int MyInt = 100;
            pt.WriteLine(MyChar);
            pt.WriteLine(MyInt);
            //下方代码为隐式转换
            MyInt = MyChar;
            pt.WriteLine(MyInt);
        }
        static void Main_数据类型转换_显示转换()
        {
            char MyChar = 'a';
            int MyInt = 10000;
            //MyChar = (char)MyInt;   //进行强制转换
            MyChar = checked((char)MyInt);  //
            pt.WriteLine(MyChar);
            pt.WriteLine(MyInt);
        }
        static void Main_数据类型转换_其它转换()
        {
            int MyInit = 100;
            string MyStr = "456";
            //MyStr = Convert.ToString(MyInit);   //用强制转换也是可以的
            MyInit = Convert.ToInt32(MyStr);
            pt.WriteLine(MyInit);
        }
    }
}
