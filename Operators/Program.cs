using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    
    internal class Program
    {
        public void ArithematicOperator(int num1, int num2)
        {
            if (num1 == 10 && num2 == 10)
            {
                Console.WriteLine("Both number is equal");
            }
            else if (num1 >= 10 || num2 >= 10)
            {
                Console.WriteLine("One of the number is greater than 10");
            }
            bool a = true;
            bool b = false;

            bool andResult = a && b;
            Console.WriteLine(andResult);
            bool orResult = a || b;
            Console.WriteLine(orResult);
            bool notResult = !a;
            Console.WriteLine(notResult);


        }
        public void BoxingandUnboxing(int a, int b)
        {
            object obj = a;                  //reference type 
            a = b;                           // value type
            Console.WriteLine("Value of Object: " + obj);
            Console.WriteLine("Value of A: " + a);
            int i = (int)obj;
            Console.WriteLine("Value after unboxing " + i);

            
        }
        public void Relational(int a  , int b)
        {
            if (a == b)
            {
                Console.WriteLine("The two number is equal");
            }
            else if(a > b)
            {
                Console.WriteLine("A is Greater than B ");
            }
            else if(a < b)
            {
                Console.WriteLine("B is greater than A");
            }

        }
        public void ternary(int b)
        {
            string c = (b>650) ? "Not Allowes to enter in the lift" : "allowed to enter in the lift";
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {

            Helper help = new Helper();
           help.SayHello();


            Console.WriteLine("Enter the First number  ");
            int num1 = int.Parse(Console.ReadLine());
            Program op = new Program();
           
             Console.WriteLine("Enter the second number  ");
             int num2 = int.Parse(Console.ReadLine());
            // op.ternary(num1);
            //op.ArithematicOperator(num1 , num2);
            // op.Relational(num1, num2);
            op.BoxingandUnboxing(num1, num2);


            Console.ReadLine();
        }
    }
}
