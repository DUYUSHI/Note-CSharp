using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4重写方法
{
    class Program
    {
        static void Main(string[] args)
        {
            /*先项目再有类，再有方法，其次有虚方法，非虚方法，定义关键字，都要new对象（就是实例化）
             * 关键字：override
             * 可访问性：protected
             * 给关键字：sealed （密封性，无法进行重写）
             */

            ClassLocalOne C1 = new ClassLocalOne();
            C1.VritualMetoud();
            ClassLocalTow C2 = new ClassLocalTow();
            C2.VritualMetoud();

            Console.ReadKey();
        }
    }
    //新建一个类
    class ClassLocalOne
    {
        public virtual void VritualMetoud()
        {
            Console.WriteLine("这是一个虚方法，这可以被重写！");
        }
    }
    //再新建一个类，用于继承ClassLocalOne
    class ClassLocalTow:ClassLocalOne
    {
        //重写方法
        public override void VritualMetoud()
        {
            Console.WriteLine("这是一个重写方法,被称为已经重写了的基方法！");
        }
    }

}
