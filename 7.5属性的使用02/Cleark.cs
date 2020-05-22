using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5属性的使用02
{
    class Cleark
    {
        /* 类中可以存放的成员：
         * 字段：采用_camelCase命名方式
         * 属性：采用PascalCase命名方式
         * 方法：
         */


        //通常将get和set称为访问器
        //属性分为：
        //  1、既读又写，同时包含get和set
        //  2、只读，只包含get
        //  3、只写，只包含set
        //  4、自动，get;set;
        public string _Name;
        public string Name
        {
            get;
            set;    //自动属性
        }
        public char _Gender;
        public char Gender
        {
            get
            {
                if (_Gender != '男' || _Gender != '女')
                {
                    _Gender = '-';
                }
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
            set //set可以用于对赋值进行限定 value
            {
                if(value<0 || value > 60)
                {
                    value = 0;
                }
                _Age = value;
            }
        }
        public int _Workyears;

        public void Write()
        {
            Console.WriteLine("Name:{0}\nGender:{1}\nAge:{2}\nDepartment:{3}\nWorkyears:{4}", this._Name, this._Gender, this._Age, this._Department, this._Workyears);

        }
    }
}
