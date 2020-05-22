using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//引入命名空间
using System.Collections;

namespace _7._9ArrayList类中元素的添加
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList类【动态数组或者集合】
             * 引入命名空间：System.Collections
             * ArrayList的好处是：长度不固定，类型随意
             */

            /* ArrayList类属性
             *      Capacity:获取或设置ArrayList可包含的元素数
             *      Count:获取ArrayList实际包好的元素数
             *      IsFixedSize:获取一一个值，该值指示ArrayList是否有固定大小
             *      IsReadOnly:或以一值，该值指示ArrayList是否为只读
             *      Item:获取或设置指定索引处的元素
             */

            ArrayList MyArrayList = new ArrayList(5);

            Console.WriteLine("MyArrayList初始化之后有{0}个元素",MyArrayList.Count);

            //Add方法用于向ArrayList中添加单个元素，每次只能添加一个
            MyArrayList.Add(123);
            MyArrayList.Add('c');
            MyArrayList.Add("字符型");
            MyArrayList.Add(123.11);
            MyArrayList.Add(10L);
            Console.WriteLine("MyArrayList初始化之后有{0}个元素", MyArrayList.Count);

            //AddRange方法用于一次性向ArrayList添加多个元素，可以是一个数组
            string[] MyStringArray = { "张三", "李四", "王五", "赵六" };
            MyArrayList.AddRange(MyStringArray);
            Console.WriteLine("使用AddRange方法后，有{0}个元素",MyArrayList.Count);

            Console.WriteLine("===================分割条===================");

            //遍历几个数组
            //引用类型：string、object类是所有类型的基础
            foreach(object MyObject in MyArrayList)
            {
                Console.WriteLine(MyObject);
            }

            Console.ReadKey();
        }
    }
}
