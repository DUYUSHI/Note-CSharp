using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._11类的多态
{
    class Milk:Drink
    {
        public override void drink()
        {
            Console.WriteLine("牛奶，可以解渴！");
        }
    }
}
