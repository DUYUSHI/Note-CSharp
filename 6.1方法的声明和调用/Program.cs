using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1方法的声明和调用
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 关键词
             *      params：用于个数不定的情况
             *      ref:传值给方法，方法中的变量修改不影响参数裂变
             *          两个限定：
             *              1、调用函数变量必须非常量
             *              2、调用变量必须初始化
             *      out:输出参数，执行方式和ref一样，当希望返回多个值时
             */



            //Console.WriteLine(Factorial(10));

            //int[] MyIntArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(Add(MyIntArray));

            //int t = 10;
            //Square(ref t);

            int[] MyInt = { 123, 23, 5, 134, 41, 5, 134, 6, 132 };
            int MaxIndex;
            Console.WriteLine("最大值：{0},最大值索引：{1}", MaxNum(MyInt,out MaxIndex), MaxIndex);

            Console.ReadKey();
        }
        static int Factorial(int Num)
        {
            int Local_Temp = 1;
            for(int i = Num; i > 0; i--)
            {
                Local_Temp *= i;
            }
            return Local_Temp;
        }
        static int Add(params int[] Num)
        {
            int Sum = 0;
            foreach(int OutSum in Num)
            {
                Sum += OutSum;
            }
            return Sum;
        }
        static void Square(ref int Num)
        {
            Num *= Num;
            Console.WriteLine(Num);
        }
        //获取数组中的最大值，返回最大值的索引
        static int MaxNum(int[] Num,out int MaxNumIndex)
        {
            int maxNumOut = Num[0];     //初始化变量为数组中的0元素
            MaxNumIndex = 0;        //初始化数组索引
            //利用for循环进行取出数组中的最大值
            for(int i = 0; i < Num.Length; i++)
            {
                //依次进行判断，得出数组最大值
                if (maxNumOut < Num[i])
                {
                    maxNumOut = Num[i];     //将目前值替换最大值
                    MaxNumIndex = i;        //更新数组最大值索引
                }
            }
            return maxNumOut;   //返回最大值
        }
    }
}
