using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        public static double Area_of_Triangle()
        {
            Console.Write("Enter the base of Triangle: ");
            int breadth = int.Parse(Console.ReadLine());
            Console.Write("Enter the height of Triangle: ");
            int height = int.Parse(Console.ReadLine());
            return 0.5 * breadth * height;
        }
        static void Main()
        {
           
            double area = Area_of_Triangle();
            Console.Write("Area: " + area);
            Console.ReadLine();




        }
    }
}
