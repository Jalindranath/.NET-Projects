using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absraction
{
    public abstract class shape
    {

        public abstract void CalculateArea();

        public virtual void display()
        {
            Console.WriteLine("Displaying the Area");
        }
    }
    public class Circle : shape
    {
        double Radius;
        double Result;
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override void CalculateArea()
        {
             Result = Math.PI * Radius * Radius;
        }
        public override void display()
        {
            Console.WriteLine($"The area is {Result}");
        }

    }
        internal class Program
    {
        static void Main(string[] args)
        {
            shape circle = new Circle(5);
            circle.CalculateArea();
            circle.display();      
            
        }
    }
}
