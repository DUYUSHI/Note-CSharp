using System;

using pt = System.Console;

namespace 字符串的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            pt.WriteLine(Main_字符串复制_Copy());
            pt.WriteLine(Main_字符串复制_CopyTo());

            pt.ReadKey();
        }
        static string Main_字符串复制_Copy()
        {
            //string.Copy(要复制的字符串)
            string MyStr = "www.wuaisite.com";
            return string.Copy(MyStr);
        }
        static char[] Main_字符串复制_CopyTo()
        {
            //Copy()，此命令无返回值
            //字符串名称.Copu(需要复制的字符起始位置,目标字符数组,目标数组的开始存放位置,需要复制的字符个数)
            string MyStr = "www.wuaisite.com";
            char[] StrTmp = new char[50];
            MyStr.CopyTo(4, StrTmp, 0, 8);  //无返回值，只需要输出StrTmp即可将内容输出
            return StrTmp;
        }
    }
}
