using System;

using pt = System.Console;

namespace 字符串替换
{
    class Program
    {
        static void Main(string[] args)
        {
            pt.WriteLine(Main_字符串替换_Replace());
            pt.ReadKey();
        }
        static string Main_字符串替换_Replace()
        {
            //字符串名称.Replace(要替换的原字符,替换后的字符串)
            string MyStr = "http://www.wuaisite.com/";
            return MyStr.Replace("http://","https://");
        }
    }
}
