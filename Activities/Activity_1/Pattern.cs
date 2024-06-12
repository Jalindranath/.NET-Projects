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
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Second Pattern: \n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n\n");
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
            Console.WriteLine("\n\n\n\n");

            /* for (int i = 0; i < 5; i++)
            {
                
                for (int j = i; j <= 5; j++)
                {
                    for (int k = j; k < 5; k++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n\n");*/



        }
    }
}
