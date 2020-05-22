using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  //引入命名空间
using System.Threading.Tasks;

namespace StringBuilder类的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //先进行初始化StringBuilder类
            StringBuilder MyStringBuilder = new StringBuilder("https://www.wuaisite.com/");
            Console.WriteLine("===========Append=============");
            Console.WriteLine(MyStringBuilder.Append("是一个神奇的网站"));   //追加一个字符串
            Console.WriteLine("===========Insert=============");
            Console.WriteLine(MyStringBuilder.Insert(25, "\n"));    //在对应位置插入指定字符串
            Console.WriteLine("===========Remove=============");
            Console.WriteLine(MyStringBuilder.Remove(25,1));    //移除从索引开始位置的N个字符串
            Console.WriteLine("===========Replace============");
            Console.WriteLine(MyStringBuilder.Replace("神奇","强大"));  //替换字符串中的内容
            Console.WriteLine("===========AppendFormat=======");
            int SaveMoney = 2000;
            Console.WriteLine(MyStringBuilder.AppendFormat("为我省了{0:C}",SaveMoney)); //按照指定的格式来添加对应的字符串
            Console.WriteLine("===========AppendLine=========");
            Console.WriteLine(MyStringBuilder.AppendLine("这句话会自动换行"));  //会自动换行

            Console.ReadKey();
        }
    }
}
