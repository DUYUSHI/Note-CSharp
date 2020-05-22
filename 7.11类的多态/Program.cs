using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._11类的多态
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 多种途径实现多态性：
             *      1、虚方法：将父类的方法标记为虚方法，使用关键字vritual，此方法在子类中可以重写（使用关键字override）
             *      2、抽象类与抽象方法：如果我们不需要使用父类创建对象，它的存在只是为了供子类继承。可将父类写成抽象（使用关键字abstract）类，将父类方法写成抽象方法，子类中的方法仍用关键字override重写。
             *      3、接口实现
             */

            /* 抽象类：不需要使用基类实例化对象
             * 虚方法：需要使用基类实例化的对象
             */

            //利用抽象来实现，类抽象话，方法抽象话，并且方法中不能有方法体{}

            /* //虚方法
                Clerk MyClerk = new Clerk();
                ProjectMannger MyPM = new ProjectMannger();

                Clerk[] clerk = { MyClerk, MyPM };
                foreach (Clerk OutClerk in clerk)
                {
                    Console.WriteLine(OutClerk);
                    OutClerk.WorkPlan();
                }
            */


                //抽象类
            //Drink MyMilk = new Drink();     //抽象类是不允许创建实例的

            //Drink MyMilk = new Milk();        //可以
            //MyMilk.drink();

            Drink MyMilk = new Milk();
            Drink MyTea = new Tea();
            Drink[] drink = { MyMilk, MyTea };

            foreach(Drink OutDrink in drink)
            {
                OutDrink.drink();
            }


            Console.ReadKey();
        }
    }
}
