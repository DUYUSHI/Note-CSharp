using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//引入命名空间
using System.Collections;

namespace _5._10ArrayList类中元素的删除
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList类删除元素的四种方法：
             *      1、ArrayList(变量名).Remove(值);
             *      2、ArrayList(变量名).RemoveAt(索引值)
             *      3、ArrayList(变量名).RemoveRange(开始索引值，需要删除的元素个数)
             *      4、ArrayList(变量名).Clear()  //q清除所有元素
             */

            //ArrayList.Remove()
            System.Collections.ArrayList MyArrayList = new System.Collections.ArrayList();
            string[] MyStringArray = { "张三", "李四", "王五", "赵六" };
            MyArrayList.AddRange(MyStringArray);
            MyArrayList.Add(3.14);
            MyArrayList.Add(2298);
            MyArrayList.Add('A');

            //第一遍未进行删除 - 遍历数组
            foreach(object MyEach in MyArrayList)
            {
                Console.WriteLine(MyEach);
            }

            Console.WriteLine("============分割条===========");

            //删除元素
            MyArrayList.Remove("张三");

            //第二遍进行删除元素后 - 遍历数组
            foreach (object MyEach in MyArrayList)
            {
                Console.WriteLine(MyEach);
            }

            Console.WriteLine("============分割条===========");
            //ArrayList(变量名).RemoveAt(索引值)
            //删除元素
            MyArrayList.RemoveAt(0);

            //第三遍进行删除元素后 - 遍历数组
            foreach (object MyEach in MyArrayList)
            {
                Console.WriteLine(MyEach);
            }

            Console.WriteLine("============分割条===========");
            //ArrayList(变量名).RemoveRange(开始索引值，需要删除的元素个数)
            //删除元素
            MyArrayList.RemoveRange(0,2);

            //第四遍进行删除元素后 - 遍历数组
            foreach (object MyEach in MyArrayList)
            {
                Console.WriteLine(MyEach);
            }

            Console.WriteLine("============分割条===========");
            //ArrayList(变量名).RemoveRange(开始索引值，需要删除的元素个数)
            //删除所有元素
            MyArrayList.Clear();

            //第五遍进行删除元素后 - 遍历数组
            foreach (object MyEach in MyArrayList)
            {
                Console.WriteLine(MyEach);
            }


            Console.ReadKey();
        }
    }
}
