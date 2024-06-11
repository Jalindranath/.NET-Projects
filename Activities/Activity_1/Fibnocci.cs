using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1
{
    internal class Fibnocci
    {
       public static void  Fibnocci_Series(int num1)
        {
            int result = 0;
            int prev = 0;
            int current = 1;
            while (num1>0)
                {
                
                Console.WriteLine(result);
                result = prev+current;
                prev = current; 
                current = result;
                num1--;
                }


        }
    }
}
