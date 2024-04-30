using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadeFunctionDemo
{
    internal class Program
    {
        public static double Area(double radius)
        {

            return Math.PI * radius * radius;
        }
        public static double Area(double baseLength, double height)
        {

            return 0.5 * baseLength * height;
        }
        public static double Area(int length, int width)
        {

            return length * width;
        }

        static void Main(string[] args)
        {
            double circleArea = Area(3.0);
            double triangleArea = Area(5.0, 5.0);
            double rectangleArea = Area(7, 8);
            Console.WriteLine("Circle Area : " + circleArea);
            Console.WriteLine("Triangle Area :" + triangleArea);
            Console.WriteLine("Rectangle Area:" + rectangleArea);


        }
    }

}
