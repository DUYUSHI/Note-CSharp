using System;

using pt = System.Console;

namespace 字符串截取
{
    class Program
    {
        static void Main(string[] args)
        {
            //string @string = "yuzmboy@Gmail.com";
            //pt.WriteLine(@string.Substring(2)); //从字符串第几个参数看是截取
            //pt.WriteLine(@string.Substring(1,5));   //截取字符串的1-5位

            pt.Write("请输出一个单词，不区分大小写：");
            string str = pt.ReadLine();
            string StrTop = str.Substring(0,1); //获取单词的首字母

            pt.WriteLine(StrTop);
           


            pt.ReadKey();
        }
    }
}
