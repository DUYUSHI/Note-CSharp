using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2枚举
{
    //在此声明枚举，它与结构的作用很类似，所以位置一样，但同时枚举也可以结构中被调用
    //默认情况下
    public enum Gender
    {
        男,
        女,  //最后一个值后方的逗号可加可不加
    }

    //人为操作下
    public enum Day
    {
        星期一,
        星期二,
        星期三 = 8,
        星期四,
        星期五,
        星期六,
        星期日
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* 声明方式:
             *     [public] enum 枚举名
             *      {
             *        值1,
             *        值2,
             *        ...
             *       }
             *      public:
             */

            //使用方式：枚举名 变量名 = 枚举名.值
            Gender LG = Gender.女;
            Console.WriteLine(LG);

            //当值转换为int型，因为默认情况下，每个值都是根据定义的顺序从0开始，自动赋予每个值一个整型，当然，也可以人为定义操作
            Console.WriteLine((int)LG);

            Day Dype = Day.星期一;
            Console.WriteLine(Dype);
            Console.WriteLine((int)Dype);

            //Day -> int (枚举转换为整型)
            Dype = Day.星期三;
            Console.WriteLine(Dype);
            Console.WriteLine((int)Dype);

            //int -> Day (整型转换为枚举)
            int Temp = 10;
            Console.WriteLine((Day)Temp);

            //Day -> string (枚举转换为字符串)  
            //不能用(string)，只能用 枚举名.ToString();或Convert.ToString(枚举值);
            Console.WriteLine(Dype.ToString());

            //string -> Day (字符串转换为枚举)
            //如果需要转换的字符串不是数字，而且枚举值中不含有该值，则会报异常
            //如果需要转换的字符串是数字，而且枚举中不包含该值，则不会报异常
            string MyString = "星期五";
            //(Day)Enum.Parse(typeof(Day), MyString);
            Console.WriteLine((Day)Enum.Parse(typeof(Day), MyString));

            Console.ReadKey();
        }
    }
}
