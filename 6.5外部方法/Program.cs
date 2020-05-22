using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _6._5外部方法
{
    //方法位置：通常类当中，并且与其他方法保持平级关系
    class Program
    {
        //使用之前必须引入命名空间：System.Runtime.InteropServices
        [DllImport("User32.dll")]

        //声明外部方法，使用关键字extern，由于配合DllImport属性使用，所以必须包含static关键字

        public static extern int MessageBox(int h, string m, string c, int type);

        static int Main(string[] args)
        {
            /*当方法中包含“extern”修饰符，则该方法称为外部方法，外部方法是在外部实现的，（编程语言通常为C#以外的语言）
             * 
             * 注意：外部方法不可以是“泛型”
             * 
             * extern修饰符通常与Dlllmport属性一起使用
             * 当外部方法包含Dlllmport属性时，该方法必须同时包含一个static修饰符
             */

            Console.Write("请输入您的姓名：");
            string Name = Console.ReadLine();
            //利用return进行弹出对话框，所以需要将Main方法改为返回值

            return MessageBox(0, "您好：" + Name + "\n" + "欢迎来到我要自学网", "提示框",0);
        }
    }
}
