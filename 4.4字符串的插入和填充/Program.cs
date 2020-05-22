using System;

using pt = System.Console;

namespace 字符串的插入和填充
{
    class Program
    {
        static void Main(string[] args)
        {
            pt.WriteLine(Main_字符串插入_insert());
            pt.WriteLine(Main_字符串填充_PadRight());
            pt.WriteLine(Main_字符串填充_PadLeft());

            pt.WriteLine();
        }
        static string Main_字符串插入_insert()
        {
            //字符串.insert(插入位置[索引值], 插入子串)
            string InsertMyStr = "www.wuaisite.com";
            string TopMyStr = "http://";
            return TopMyStr.Insert(7, InsertMyStr); //在TopMyStr字符的第六个位置插入InsertMyStr变量值
        }
        static string Main_字符串填充_PadRight()
        {
            //字符串.PadRight(总长度,要填充的字符)   以空格填充
            string MyStr = "http:";
            return MyStr.PadRight(7,'/');
        }
        static string Main_字符串填充_PadLeft()
        {
            //字符串.PadLeft(总长度,要填充的字符)
            string MyStr = "http:";
            return MyStr.PadLeft(7,'/');
        }
    }
}
