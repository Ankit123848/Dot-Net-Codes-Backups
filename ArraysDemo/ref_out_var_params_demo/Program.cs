using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_var_params_demo
{
    internal class Program
    {
        static void RectangleArea(ref double length, ref double breadth, out double area)
        {
            area = length * breadth;
        }
        static void Main(string[] args)
        {
            double length = 5.0;
            double breadth = 3.0;
            double area;

            RectangleArea(ref length, ref breadth, out area);

            Console.WriteLine("Area of Reactangle = {0}" ,area);
        }
    }
}
