using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1
{
    internal class Swap
    {
        public static void Swapping()
        {
            Console.WriteLine("Enter the two Number ");
            Console.Write("Number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Number 2: ");

            int num2 = int.Parse(Console.ReadLine());
            Console.Write($"\n\nBefore Swapping\n Number 1: {num1} \n Number 2: {num2}");

            num1 +=  num2;
            num2 = num1 - num2;
            num1 -= num2 ;

            Console.Write($"\n\nAfter Swapping\n Number 1: {num1} \n Number 2: {num2}\n");



        }
    }
}
