using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._8数组合并和拆分
{
    class Program
    {
        static void Main(string[] args)
        {
            /*数组合并与拆分
             * Array提供copy方法（共4个重载（则四种参数方式））
             *  1、Array.Copy(数组1,数组2,长度)
             *  2、Array.Copy(数组1,数组2,Int64)     //64位
             *  3、Array.Copy(数组1,指定索引,数组2,指定索引,长度)
             *  4、Array.Copy(数组1,指定索引,数组2,指定索引,长度)      //64位
             */

            int[] MyIntArray1 = { 0, 1, 2, 3, 4};
            int[] MyIntArray2 = { 5, 6, 7, 8, 9, 10 };
            int[] MyIntArrayMerge = new int[20];

            //数组的合并
            Console.Write("原数组1为:");
            foreach (int MyInt in MyIntArray1)
            {
                //遍历原数组MyIntArray1
                Console.Write(MyInt + "\t");
            }
            Console.Write("\n原数组2为:");
            foreach (int MyInt in MyIntArray2)
            {
                //遍历原数组MyIntArray2
                Console.Write(MyInt + "\t");
            }

            //第一种重载
            Console.Write("\n使用第一种重载：");
            //从MyIntArray1数组中，从索引0开始，取5个长度的索引值放入MyIntArrayMerge数组中，从MyIntArrayMerge数组的索引0开始存储
            Array.Copy(MyIntArray1, MyIntArrayMerge, 5);    
            foreach (int MyInt in MyIntArrayMerge)
            {
                //遍历原数组MyIntArrayMerge
                Console.Write(MyInt + "\t");
            }

            //第三种重载
            Console.Write("\n使用第三种重载：");
            //表示从数组MyIntArray1中提取从索引0开始的5个元素，存到到数组MyIntArrayMerge中，从数组MyIntArrayMerge的索引10开始存储
            Array.Copy(MyIntArray1, 0, MyIntArrayMerge, 10, 5);     
            foreach(int MyInt in MyIntArrayMerge)
            {
                //遍历原数组MyIntArrayMerge
                Console.Write(MyInt + "\t");
            }

            //数组的拆分
            //例如，拆分数组MyIntArray2，
            int[] MyIntSplit = new int[10];
            Console.Write("\n数组的拆分：");
            Array.Copy(MyIntArray2, 3, MyIntSplit,7, 2);
            foreach (int MyInt in MyIntSplit)
            {
                //遍历原数组MyIntArray2
                Console.Write(MyInt + "\t");
            }


            Console.ReadKey();
        }
    }
}
