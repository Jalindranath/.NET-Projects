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

        public static double Area_of_Reactangle()
        {
            Console.Write("Enter the base of Triangle: ");
            int Length = int.Parse(Console.ReadLine());
            Console.Write("Enter the height of Triangle: ");
            int Breadth = int.Parse(Console.ReadLine());
            return Length * Breadth;
        }
        public static double Area_of_Polygon()
        {
            Console.Write("Enter the Perimeter of Polygon: ");
            int breadth = int.Parse(Console.ReadLine());
            Console.Write("Enter the Apothem i.e radius of Polygon: ");
            int height = int.Parse(Console.ReadLine());
            return 0.5 * breadth * height;
        }

        static void Main()
        {
            Console.WriteLine(" 1. Area of Triangle\n 2. Area of Rectangle\n 3. Area of Polygon \n 4. Date and Local Time\n Enter Choice\n ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    double area = Area_of_Triangle();
                    Console.Write("Area: " + area);
                    break;
                
                case 2:
                    area = Area_of_Reactangle();
                    Console.Write("Area: " + area);
                    break;
                case 3:
                    area = Area_of_Polygon();
                    Console.Write("Area: " + area);
                    break;
                case 4:
                    DateTime dateTime = DateTime.Now;
                    Console.WriteLine(dateTime);
                    break;




            }
           
            
            Console.ReadLine();




        }
    }
}
