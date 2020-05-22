using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4属性的使用01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*属性的作用：保护字段，对字段的取值与赋值进行限定
             * 说明：属性往往被声明在字段下方，并且将字段私有化
             * 格式：public [对于字段类型] 属性名
             * {
             *      get{return _name};
             *      set{_name = value};
             * }
             */

            //将类实例化，并分别赋值，并调用其中的方法
            //Cleark LG = new Cleark();
            //LG._Name = "张三";
            //LG._Gender = '男';
            //LG._Age = 25;
            //LG._Department = "人力资源部";
            //LG._Workyears = 5;

            Cleark LG = new Cleark();
            LG._Name = "张三";
            LG.Gender = '男';
            LG._Age = 25;
            LG._Department = "人力资源部";
            LG._Workyears = 5;

            LG.Write();

            Console.ReadKey();
        }
    }
}
