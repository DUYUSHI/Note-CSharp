using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._6构造函数和析构函数01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*作用：帮助我们初始化对象（给对象的每个属性依次的赋值）
             * 构造函数是一个特殊的方法：
             *      1、构造函数没有返回值，连void也不能写，必须public。
             *      2、构造函数的名称必须跟类名一样
             */


            //ClassLei LG = new ClassLei();
            //LG.Name = "张三";
            //LG.GenderT = Gender.男;
            //LG.Age = 25;
            //LG.Department = "人力资源部";
            //LG.Write();

            ClassLei LG = new ClassLei("张三",Gender.男,25,"IT部门");
            LG.Write();

            Console.ReadKey();
        }
    }
}
