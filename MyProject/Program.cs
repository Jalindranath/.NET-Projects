using System;
using System.Runtime.Remoting.Messaging;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Roll Number and Names");
            int[] Record;
            Record = new int[3];
            int i = 0;

            object[] names;                                           //Object is created
            names = new object[3];
            string Name;
            for(i=0 ; i<3; i++)
            {
                Console.WriteLine("Roll: ");
                Record[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");

                Name = Console.ReadLine();
                names[i] = Name;                  //Boxing
            }


            Console.WriteLine("Enter the Roll No.");
            int Target = int.Parse(Console.ReadLine());
            int Flag = 0;
            for(i  = 0; i<3; i++)
            {
                if(Target == Record[i])
                {
                    Console.WriteLine("Record Found....");
                    Console.WriteLine($"Roll: {Record[i]} Name: {(string)names[i]}");  //Unboxing
                    Flag = 1;
                    break;
                }
                
            }

            if (Flag == 0)
            {
                Console.WriteLine("Record is not present....");
            }






        }
    }
}
