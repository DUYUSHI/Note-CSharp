using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4属性的使用01
{
    class Cleark
    {
        /*属性的作用：保护字段，对字段的取值与赋值进行限定
         * 说明：属性往往被声明在字段下方，并且将字段私有化
          */

        //当我们有了属性之后，我们通常都会通过属性来访问字段
        //打个比方：属性为男人，负责外部事物；字段为女人，负责内部事务

        //属性通常声明为public 字段什么private
        //在外部访问类中的字段，都是通过属性来实现的

        //类中可存放的成员：字段、属性、方法
        public string _Name;
        public char _Gender;
        public char Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
            }
        }
        public string _Department;
        public int _Age;
        public int Age
        {
            get //get可以用于对取值进行限定
            {
                return _Age;
            }
            set //set可以用于对赋值进行限定
            {
                _Age = value;
            }
        }
        public int _Workyears;

        public void Write()
        {
            Console.WriteLine("Name:{0}\nGender:{1}\nAge:{2}\nDepartment:{3}\nWorkyears:{4}",this._Name,this._Gender,this._Age,this._Department,this._Workyears);

        }
    }
}
