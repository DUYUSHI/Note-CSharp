using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._11类的多态
{
    abstract class Drink
    {
        //利用抽象来实现，类抽象话，方法抽象话，并且方法中不能有方法体{}
        public abstract void drink();
        //{
        //    Console.WriteLine("饮料，可以解渴！");
        //}
    }
}
