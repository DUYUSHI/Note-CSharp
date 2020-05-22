using System;

using pt = System.Console;

namespace 字符串修剪
{
    class Program
    {
        static void Main(string[] args)
        {
            pt.WriteLine(Main_字符串修剪_Trim_带参());
            pt.WriteLine(Main_字符串修剪_Trim());
            pt.WriteLine(Main_字符串修剪_TrimStart ());
            pt.WriteLine(Main_字符串修剪_TrimEnd());

            pt.ReadKey();
        }
        static string Main_字符串修剪_Trim_带参()
        {
            //删除首尾空格
            //Trim()删除字符串首付和尾部的空格
            //字符串名称.Trime(参数)
            //      参数 = '字符'
            //      参数 = '字符'.ToCharArray
            string MyStr = "#$#http://www.wuaisite.com$#  ";
            return MyStr.Trim('#','$');
        }
        static string Main_字符串修剪_Trim()
        {
            //删除首尾空格
            //Trim()删除字符串首付和尾部的空格
            //字符串名称.Trime()
            string MyStr = "  http://www.wuaisite.com/  ";
            return MyStr.Trim();
        }
        static string Main_字符串修剪_TrimStart()
        {
            //删除头部空格
            //字符串名称.TrimStart()
            string MyStr = "        http://www.wuaisite.com/";
            return MyStr.TrimStart();
        }
        static string Main_字符串修剪_TrimEnd()
        {
            //删除字符串尾部空格
            //字符串名称.TrimEnd()
            string MyStr = "   http://www.wuaisite.con/     ";
            return MyStr.TrimEnd();
        }
    }
}
