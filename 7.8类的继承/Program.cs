using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._8类的继承
{
    class Program
    {
        static void Main(string[] args)
        {
            // 此章，课程讲的迷迷糊糊，本人已经迷失！！！！

            /* 面向对象的三个基本特征：封装、继承、多态
             * 当一个类从另一个类派生出来时，派生类就自然具有基础类数据成员、属性成员、方法成员等
             */

            /* 对类而言，所谓继承就是子类包含父类的数据结构和行为方式，包括字段、属性、方法和事件
             */

            /* 在类的继承中，被继承的类叫做基类或父类、继承的类叫派生类或子类
             */

            //格式：派生类:基类

            /* 类继承的注意规则：
             *  1、单根性（只能继承一个类）
             *  2、传递性（2继承1，3继承2，则3包含有1和2）
             *  3、派生类定义与基类同名的成员，则覆盖基类成员（如果想要完全覆盖，必须使用new关键字）
             *  4、派生类自然继承基类的成员，但不能继承基类的构造函数的成员
             */

            Clerk LG = new Clerk("张三", "人力资源部");
            LG.ClerkWrite();
            Sales ZS = new Sales("张三", "人力资源部",60);
            ZS.SalesWrite();
            Console.ReadKey();
        }
    }
}
