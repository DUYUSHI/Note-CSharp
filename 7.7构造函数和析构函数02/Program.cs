using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7构造函数和析构函数02
{
    /* 构造函数支持重载
     */
    class Program
    {
        static void Main(string[] args)
        {
            /* new关键字：
             *      1、在内存中开辟控件
             *      2、在开辟的空间中创建对象
             *      3、对对象进行初始化，将各个属性值赋值
             */

             /* 析构函数：实现销毁一个类的实例的方法成员
              *     不能有参数
              *     不能有任何修饰符，而且不能被调用
              *     析构函数与构造函数不同，特在析构函数前加前缀“~”以示区别
              * 在使用完当前类的时候会调用析构函数
              */

            ClassLei LGT = new ClassLei("李四", Gender.男, 24,"人力资源部");
            LGT.Write();

            ClassLei LG = new ClassLei("李四",Gender.男,24);

            LG.Write();
            Console.ReadKey();
        }
    }
}
