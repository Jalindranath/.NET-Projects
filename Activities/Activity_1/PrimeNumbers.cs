using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1
{
    internal class PrimeNumbers
    {
        public static void Find_All_Prime_Numbers()
        {
            Console.Write("Enter the Final Limit");
            int limit  = int.Parse(Console.ReadLine());
            for (int i = 2; i < limit; i++) {
                int Flag = 0;
                for (int j = 2; j <= (i / 2); j++) {
                    if ((i % j) == 0)
                    {
                        Flag = 1;
                        break;
                    }
                    }
                if (Flag == 0)
                {
                    Console.WriteLine("Prime Number: " + i);
                }
                Flag = 0;
            }
        }
    }
}
