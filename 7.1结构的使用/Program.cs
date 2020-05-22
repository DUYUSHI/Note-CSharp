using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1结构的使用
{
    /* 结构声明方式：struct
     * 声明位置：命名空间下面，类的外面，表示这个命名空间下所有的类都可以使用这个结构
     */
     public struct Clerk
    {
        //声明变量
        //将此处的变量声明为Public(公共的)
        public string Name;
        int Age;
        string Gender;
    }
    class Program
    {
        //如果将“结构”声明在此类中，那么只有当前类或者继承类可以访问
        static void Main(string[] args)
        {
            //使用结构时：结构名 变量名 = new 结构名();
            Clerk Name = new Clerk();
            Name.Name = "张三";
            

            Console.ReadKey();
        }
    }
}
