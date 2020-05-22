using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._7方法的重载
{
    class Program
    {
        //求圆面积
        static double WriteArer(int radius)
        {
            double area = System.Math.PI * radius * radius;
            return area;
        }
        //求矩形面积
        static int WriteArer(int Width,int length)
        {
            int area = Width * length;
            return area;
        }
        //求三角形面积
        static double WriteArer(int A,int B,int C)
        {
            double p = (A + B + C) / 2;
            double area = System.Math.Sqrt(p*(p-A)*(p-B)*(p-C));
            return area;
        }
        static void Main(string[] args)
        {
            /*
             */

            Console.WriteLine(WriteArer(3));
            Console.WriteLine(WriteArer(5,3));
            Console.WriteLine(WriteArer(3,4,5));

            Console.ReadKey();
        }
    }
}
