using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            /*虚方法：在一个实例方法的声明中含有virtual修饰符，则称该方法为“虚方法”，反之则“非虚方法”
             */

            ClassLei cls = new ClassLei();    //将类进行实例化            
            cls.NonVirtualMethod();
            cls.VirtualMehtod();

            ClassLeiOne cls2 = new ClassLeiOne();
            cls2.NonVirtualMethod();
            cls2.VirtualMehtod();
            cls2.VirtualMethod();

            Console.ReadKey();
        }
    }
    class ClassLei
    {
        //默认的方法被指定为私有的，只能在当前类中进行访问pribate
        //需要在其它类中访问，就需要将其指定为Public访问权限最高，只要在项目内部可以进行访问

        //虚方法能够在派生类中进行重写
        public virtual void VirtualMehtod()
        {
            Console.WriteLine("这是一个虚方法！");
        }
        public void NonVirtualMethod()
        {
            Console.WriteLine("这是一个非虚方法！");
        }
    }
    class ClassLeiOne : ClassLei   //将ClassLeiOne继承于ClassLei
    {
        public new void NonVirtualMethod()
        {
            Console.WriteLine("这是一个新方法！");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("这是一个新写的虚方法！");
        }

    }
}
