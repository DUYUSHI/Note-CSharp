using System;

using pt = System.Console;

namespace 字符串分割
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main_字符分割();
            Main_字符数组();

            pt.ReadKey();
        }
        static void Main_字符分割()
        {
            string str = "0-1-2-3-4-5-6-7-8-9-10";
            pt.Write("原字符为：" + str);
            pt.WriteLine("\n用 - 分割后的字符为：");
            string[] Temp = str.Split('-');  //获取单个分割字符

            foreach (string outstr in Temp)
            {
                pt.Write(outstr + "\t");
            }
        }
        static void Main_字符数组()
        {
            string str = "0-1-2-3-4-5-6-7-8-9-10=11=12=13=14=15=16=17=18=19=20";
            string[] _str_ = str.Split(new char[] {'-','='});
            foreach (string outstr in _str_)
            {
                pt.WriteLine(outstr + '\t');
            }
        }
    }
}
