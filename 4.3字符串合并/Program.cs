using System;

using pt = System.Console;

namespace 字符串合并
{
    class Program
    {
        static void Main(string[] args)
        {
            pt.WriteLine("字符串的合并");
            pt.WriteLine(Main_字符串合并_01());
            pt.WriteLine(Main_字符串合并_02());
            pt.WriteLine(Main_字符串合并_03());
            pt.ReadKey();
        }
        static string Main_字符串合并_01()
        {
            string str1 = "YuZMboy";
            string str2 = "@";
            string str3 = "Gmail";
            string str4 = ".com";
            //string.concat(字符串1,字符串2,....)  利用string类中的concat函数进行合并 
            return string.Concat(str1,str2,str3,str4);
        }
        static string Main_字符串合并_02()
        {
            string str1 = "YuZMboy";
            string str2 = "@";
            string str3 = "Gmail";
            string str4 = ".com";
            return str1 + str2 + str3 + str4;
        }
        static string Main_字符串合并_03()
        {
            string [] Tstr = {"YuZM","@","Gmail",".com" };
            //string.Join(合并后的分隔符,字符串数组)
            return string.Join("",Tstr);
        }
    }
}
