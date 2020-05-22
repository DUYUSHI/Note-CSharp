using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._9类的封装
{
    public class ClassLei02:ClassLei01
    {
        private string _dep;
        public string Dep
        {
            get { return _dep; }
            set { _dep = value; }
        }

        //在类中编写一个方法
        public void ClassLei02Write()
        {
            Console.WriteLine("{0},{1},{2},{3}",this.Name,this.Age,this.GD,this.Dep);
        }

        //构造函数
        public ClassLei02(string name,int age,Gender gd,string dep) : base(name, age, gd)
        {
            this.Dep = dep;

            //测试是否可以在子类中访问protected字段
            //this.MyText = "受保护的字段，可以在子类中访问";
        }
    }
}
