using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6分部方法
{
    //分部方法
    public partial class Program
    {
        static void Main(string[] args)
        {
            /* 分部方法：方法中包含partial修饰符
             *          必须在分部类或分部结构中声明，必须私有
             * 严格要求：
             *      1、方法必须放回void，只能默认为private
             *      2、不能为virtual和extern方法
             *      3、可以有ref参数，但不能有out参数
             */

            //调用分部方法
            //Write();    //不能直接调用
            Program p = new Program();
            p.Write();

            Console.ReadKey();
        }
    }
    public partial class Program
    {
        //声明定义一个分部类
        //声明分部方法
        //方法默认为私有，也可以人为加上pribate
        partial void Write();
        partial void Write()
        {
            Console.WriteLine("This is partial.");
        }
    }
}
