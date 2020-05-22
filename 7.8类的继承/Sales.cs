using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._8类的继承
{
    //继承于Clerk类
    //格式：派生类:基类
    class Sales : Clerk
    {
        //new关键字可以用来隐藏基类中相同名称的成员
        //new还可以实例化对象
       /*
            private string _name; 
            public new string Name  //如果想完全覆盖，必须使用new关键字
            {
                get { return _name; }
                set{ _name = value; }
            }
        */
        private int _SalesTarget;
        public int SalesTarget
        {
            get{ return _SalesTarget; }
            set{ _SalesTarget = value; }
        }
        public void SalesWrite()
        {
            Console.WriteLine("我是{0}的{1}，销售目标:{2}",this.Department,this.Name,this.SalesTarget);
        }

        //在子类中编写一个构造函数
        //public Sales(string name,string department,int salestarget)
        //{
        //    this.Name = name;
        //    this.Department = department;
        //    this.SalesTarget = salestarget;
        //}

        public Sales(string name,string department,int salesTarget) : base(name, department)
        {
            this.SalesTarget = salesTarget;
        }
    }
}
