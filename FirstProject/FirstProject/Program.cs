using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("What is your name? ");
            String name = Console.ReadLine();
            int age;
            Console.WriteLine("Enter yout age");
            while(!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("you have not enter the valid age");
                Console.WriteLine("Again enter your age");
            }

            Console.WriteLine($"Hi, {name} your age is {age}");
            Odd and even
            Console.Write("Enter the number: ");
            String str = Console.ReadLine();
            
            int num;
            bool number = int.TryParse(str, out num);
            if (num % 2 == 0)
                Console.WriteLine("Number is even \n");
            else
                Console.WriteLine("Number is odd \n ");*/

            // Swapping two numbers
            Console.WriteLine("Enter the  first number: ");
            String str1 = Console.ReadLine();
            Console.WriteLine("Enter the second number: ");
            String str2 = Console.ReadLine();
            int num1 , num2;
            bool number1 = int.TryParse(str1, out num1);
            bool number2 = int.TryParse(str2, out num2);
            Console.WriteLine($"Before swapping: Num1-> {num1}  Num2-> {num2} ");
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After swapping:  Num1-> {num1}  Num2-> {num2}");
            Console.ReadLine();

            
        }
    }
}
