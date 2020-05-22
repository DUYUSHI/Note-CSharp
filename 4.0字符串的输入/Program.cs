using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串的输入
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====此章节为[字符串输入]======");
            string MyStr = Console.ReadLine();
            Console.WriteLine(StringLeng(MyStr));

            Console.ReadKey();
        }
        static int StringLeng(string Name)
        {
            //获取字符串长度
            int Local_return = 0;
            for(int Local = 0;Local <Name.Length;Local++)
            {
                Name.Substring(Local,1);
                Local_return = Local_return + 1;
            }
            return Local_return;
        }
    }
}
