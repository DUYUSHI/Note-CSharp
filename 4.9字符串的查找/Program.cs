using System;

using pt = System.Console;

namespace 字符串的查找
{
    class Program
    {
        static void Main(string[] args)
        {
            pt.WriteLine(Main_字符串查找_IndexOf());
            pt.WriteLine(Main_字符串查找_LastIndexOf());

            pt.ReadKey();
        }
        static int Main_字符串查找_IndexOf()
        {
            //字符串名称.IndexOf(需要查找的字符串或字符)
            //返回第一次查找到的字符或字符串出现位置
            //返回类型：整数型(int)
            //无查找结果：返回一个负数
            string MyStr = "www.wuaisite.com";
            return MyStr.IndexOf("wuaisite");
        }
        static int Main_字符串查找_LastIndexOf()
        {
            //字符串名称.LastIndexOf(需要查找的字符串或字符)
            //返回最后一次查找到的字符或字符串的出现位置
            //返回类型：整数型(int)
            //无查找结果：返回一个负数
            string MyStr = "www.wuaisite.com";
            return MyStr.IndexOf("wuaisite");
        }
    }
}
