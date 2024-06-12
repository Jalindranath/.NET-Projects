using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1
{
    internal class Pattern
    {
        public static void patterns()
        {
            Console.WriteLine("\nFirst Pattern: \n");
            
            for(int i= 0; i< 5; i++)
            {
                for(int j= i; j< 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Second Pattern: \n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Third Pattern: \n");
            for (int i = 0; i < 5; i++)
            {
                for (int k = i; k < 5; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Fourth Pattern: \n");

            for (int i = 0; i < 5; i++)
            {
                
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" ");
                }
                
            }
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Fifth Pattern: ");

            for (int i = 1; i <= 5; i++)
            {
                // Print spaces
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sixth Pattern: ");
            for (int i = 1; i <= 5; i++)
            {
                // Print spaces
                for (int k = (2 * i - 1); k >= 1; k--)
                {
                    Console.Write("*");
                }
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                
                Console.WriteLine();
            }



        }
    }
}
