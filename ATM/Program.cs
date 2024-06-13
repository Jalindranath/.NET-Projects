using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t WELCOME TO ATM SERVICES");
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("Enter Your PIN: ****");

            Console.WriteLine("\t\t\t1. CHECK BALANCE\n\t\t\t2. CASH DEPOSITE\n\t\t\t3. CASH WITHDRAW\n\t\t\t4. QUITE");
            int a = int.Parse(Console.ReadLine());
            if(a == 1)
            {
                Console.WriteLine("\t\t\t1. CHECK BALANCE\n");
                Console.WriteLine("\t\t\t Your Balance is 1000");

                Console.WriteLine("\t\t\tThank you using these ATM\n\n");
            }
        }
    }
}
