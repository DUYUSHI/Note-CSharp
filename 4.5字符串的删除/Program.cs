using System;

using pt = System.Console;

namespace 字符串的删除
{
    class Program
    {
        static void Main(string[] args)
        {
            pt.WriteLine(Main_字符串删除_Remove());

            pt.ReadKey();
        }
        static string Main_字符串删除_Remove()
        {
            //字符串.Remove(开始位置,移出数)
            string MyStr = "https://www.wuaisite.com";
            return MyStr.Remove(6,2) ;
        }
    }
}
