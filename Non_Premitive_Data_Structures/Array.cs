using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Non_Premitive_Data_Structures
{
    internal static class Array
    {
        

        public static void Array_Input()
        {
            int Size ;

            Console.WriteLine("Enter the Size of the array ");
            Size = int.Parse(Console.ReadLine());

            int[] array = new int[Size];
            int Element;
            Console.WriteLine("Enter the Element of Array");
            for (int i = 0; i < Size; i++)
            {
                Element = int.Parse(Console.ReadLine());
                array[i] = Element;
            }
            Console.WriteLine("The Element of Array in Reverse Order: ");
            for (int i = Size - 1; i >= 0; i--)
            {
                Console.Write(array[i]+"   ");
            }

        }
        public static void Array_2D_Inout_Operations()
        {
            int[,] First = new int[3, 3];
            int[,] Second = new int[3, 3];
            int[,] Addition = new int[3, 3];
            int[,] Substraction = new int[3, 3];
            int[,] Multiplication = new int[3, 3];
            double[,] Divison = new double[3, 3];
            double[,] Modulo = new double[3, 3];






            Console.WriteLine("Enter the First 2D Array of Size 3*3: ");
            for(int i = 0; i  < 3; i++)
            {
                for(int  j = 0; j < 3; j++)
                {
                    Console.Write($"Enter the Element at [{i}][{j}]:   ");

                    First[i,j] = int.Parse(Console.ReadLine()) ;
                }
            }
            Console.WriteLine("Enter the Second 2D Array of Size 3*3: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter the Element at [{i}][{j}]:   ");
                    Second[i, j] = int.Parse(Console.ReadLine());
                    Addition[i, j] = First[i, j] + Second[i, j];
                    Substraction[i,j]= First[i, j] - Second[i, j];
                    Multiplication[i,j] = First[i, j] * Second[i, j];
                    Divison[i,j] = First[i, j] / Second[i, j];
                    Modulo[i,j] = First[i, j] % Second[i, j];

                }
            }
            Console.WriteLine("Addtion of 2D Array of Size 3*3 : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   Console.Write(Addition[i, j] +"   ");
                   
                }
                Console.WriteLine();
            }

            Console.WriteLine("Substraction of 2D Array of Size 3*3 : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Substraction[i, j] + "   ");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Multiplication of 2D Array of Size 3*3 : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Multiplication[i, j] + "   ");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Division of 2D Array of Size 3*3 : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Divison[i, j] + "   ");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Modulous of 2D Array of Size 3*3 : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Modulo[i, j] + "   ");

                }
                Console.WriteLine();
            }

           
        }
        
    }
}
