using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Prime Numbers between 1 to 100 or 1 to n
 * Swap two variables without using third variable
 * Find the factorial of number
 * Print the fibnacci series*/
namespace Activity_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" 1. Prime Numbers between  1 to N\n 2. Swap two variables without using third variable\n 3. Find the factorial of number\n 4. Print the Fibnacci Series \n 5. Pattern Choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                        PrimeNumbers.Find_All_Prime_Numbers();
                        break;
                    
                case 2:
                    Swap.Swapping();
                    break;
                case 3:
                    Console.Write("Number : ");
                    int num1 = int.Parse(Console.ReadLine());
                    int result = Factorial.Find_Factorial(num1);
                    Console.Write($"\nFactorial of {num1} : {result}\n");
                    break;
                case 4:
                    Console.Write("Number : ");
                    num1 = int.Parse(Console.ReadLine());
                    Fibnocci.Fibnocci_Series(num1);
                    break;
                case 5:
                    
                    Pattern.patterns();
                    break;

            }
            Console.ReadLine();

        }
    }
}
