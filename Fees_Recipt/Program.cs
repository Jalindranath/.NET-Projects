using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fees_Recipt
{
    internal class Program
    {
        static void Main(string[] args)
        { // Header
            Console.WriteLine("Name: ");
            String Name = Console.ReadLine();
            DateTime now = DateTime.Now;
            string currentDate = now.ToString("dd/MM/yyyy");
            string currentTime = now.ToString("hh:mm tt");
            Console.WriteLine("\t\t\t\t\t***************************************");
            Console.WriteLine("\t\t\t\t\t  SANJIVANI COLLEGE OF ENGINEERING");
            Console.WriteLine("\t\t\t\t\t  ~ Academic Fee Receipt ~");
            Console.WriteLine("\t\t\t\t\t***************************************\n");

            // Student Information
            Console.WriteLine($"\t\t\tName: {Name}\t\t\t\tDate: {currentDate}");
            Console.WriteLine($"\t\t\tUSN: ********\t\t\t\t\tTime: {currentTime}");
            Console.WriteLine("\t\t\tBranch: IT, OR CSE");
            Console.WriteLine("\t\t\tYear/Sem: 2024-2025 / 7th Sem\n\n");

            int entranceFee = 5000;
            int examsFee = 2000;
            int libraryFee = 1500;
            int hostelFee = 10000;
            int laboratoryFee = 3000;
            int projectClassFee = 2500;

            int totalFee = entranceFee + examsFee + libraryFee + hostelFee + laboratoryFee + projectClassFee;
            double gst = totalFee * 0.18;
            double grand = gst + totalFee;

            // Fees Details
            Console.WriteLine($"\t\t\t1) Entrance \t\t\t{entranceFee}");
            Console.WriteLine($"\t\t\t2) Exams \t\t\t{examsFee}");
            Console.WriteLine($"\t\t\t3) Library \t\t\t{libraryFee}");
            Console.WriteLine($"\t\t\t4) Hostel \t\t\t{hostelFee}");
            Console.WriteLine($"\t\t\t5) Laboratory \t\t\t{laboratoryFee}");
            Console.WriteLine($"\t\t\t6) Project & Class \t\t{projectClassFee}\n");

            // Total and GST
            int total = 25000;
            Console.WriteLine($"\t\t\tTotal  \t\t\t\t{totalFee}");
            Console.WriteLine($"\t\t\tGrand Total \t\t\t{grand}");

            // To keep the console window open
            Console.ReadLine();
        }
    }
}
