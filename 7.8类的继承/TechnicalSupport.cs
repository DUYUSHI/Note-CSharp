using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._8类的继承
{
    class TechnicalSupport : Clerk
    {
        private double _satisfactionRate;
        public double SatisfactionRate
        {
            get{return _satisfactionRate;}
            set{_satisfactionRate = value;}
        }
        public void TecWrite()
        {
            Console.WriteLine("我是{0的{1},我的服务满意率为{2}",this.Department,this.Name,this.SatisfactionRate);
        }

        //在子类中编写子类的构造函数
        //public TechnicalSupport(string name, string department, double satisfactionRate)
        //{
        //    this.Name = name;
        //    this.Department = department;
        //    this.SatisfactionRate = satisfactionRate;
        //}

        //构造函数base
        public TechnicalSupport(string name,string prdepartment,double satis) : base(name, prdepartment)
        {

        }
    }
}
