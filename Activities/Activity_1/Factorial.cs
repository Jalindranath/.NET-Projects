using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1
{
    internal class Factorial
    {
        public static int Find_Factorial(int num)
        {
            if (num <= 1)
            {
                return 1;
            }
            else
                return num * Find_Factorial(num - 1);
        }
    }
}
