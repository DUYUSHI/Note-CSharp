using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._9类的封装
{
    class Program
    {
        static void Main(string[] args)
        {
            //封装是实现面向对象程序设计的第一步
            //将程序或函数等集合在一个个单元中
            //意义：有利于我们保护或防止代码被我们无意中破坏，防止对实现细节的访问（后半句劳资没搞懂）

            //类成员默认为private，一般我们为便于识别，认为在前面加上private，加与不加意义一样

            /* 访问修饰符：
             *  1、public
             *      (公开的)
             *      允许一个类将其成员变量和成员函数暴露给其他的函数和对象。
             *      任何公有成员可以被外部的类访问。
             *  2、private
             *      （只能在当前类的内部访问，类成员的默认访问修饰符）
             *      允许一个类将其成员变量和成员函数对其他的函数和对象进行隐藏。
             *      只有同一个类中的函数可以访问它的私有成员。即使是类的实例也不可以访问它的私有成员
             *  3、protected
             *      （受保护的，只能在当前类内部及子类中访问）
             *      允许子类访问它的基类的成员变量和成员函数【有助于实现继承】
             *  4、internal
             *      （只能在当前项目中访问。在同一个项目中，internal和public的权限一样）
             *      允许一个类将其成员变量和成员函数暴露给当前程序中的其他函数和对象。换句话说，带有inernal访问修饰符的任何成员可以被定义在该成员所定义的应用程序内的任何类或方法访问。
             *  5、protected internal
             *      允许一个类将其他成员变量或成员函数对同一应用程序内的子类以外的其他的类对象和函数进行隐藏。【也被用于实现继承】
             */

            /* 1)能够修饰类的访问修饰符只有两个：
             *      1、public
             *      2、internal
             * 2)可访问性一致
             * 
             * 子类的访问权限不能高于父类的访问权限
             */

            ClassLei01 LG = new ClassLei01("张三",24,Gender.男);
            //LG.Name = "张三";
            //LG.Age = 25;
            //LG.GD = Gender.男;
            LG.ClassLei01Write();


            Console.ReadKey();
        }
    }
}
