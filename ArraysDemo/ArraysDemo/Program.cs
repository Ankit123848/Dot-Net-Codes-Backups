using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    internal class Program
    {
        static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            double area = CircleArea(radius);

            Console.WriteLine("The area of the circle with radius {0} is: {1}", radius, area);

            Console.ReadKey();
        }
        

    }
}
