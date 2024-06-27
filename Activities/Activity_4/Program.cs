using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;

namespace Activity_4

{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Get Daylight Saving Information");
            Console.WriteLine("2. Create a Gray Code");
            Console.WriteLine("3. Convert Celsius to Fahrenheit");
            Console.WriteLine("4. Get IP Address");
            Console.WriteLine("5. Implement PhoneBook");
            Console.WriteLine("6. Create a Stop Watch");
            Console.WriteLine("7. Generate the Marksheet of the Student");
            Console.WriteLine("8. Convert Meter to Kilometer and Vice versa");
            Console.WriteLine("9. Display Squarefeet of a House");
            Console.WriteLine("10. Convert Infix to Postfix");
            Console.WriteLine("11. Demonstrate Multilevel Inheritance with Virtual Methods");
            Console.WriteLine("12. Implement Delegates");
            Console.WriteLine("13. Traverse the Singly Linked List");
            Console.WriteLine("14. Sort a List of Names in Alphabetical Order");
            Console.WriteLine("15. Find the Smallest Element in a Matrix");
            Console.WriteLine("16. Find the Largest Element in a Matrix");
            Console.WriteLine("17. Demonstrate Jagged Arrays");
            Console.WriteLine("18. Calculate Distance, Speed and Time");
            Console.WriteLine("19. Find Simple Interest");
            Console.WriteLine("20. Convert Digits to Words");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    GetDaylightSavingInformation();
                    break;
                case 2:
                    CreateGrayCode();
                    break;
                case 3:
                    ConvertCelsiusToFahrenheit();
                    break;
                case 4:
                    GetIPAddress();
                    break;
                case 5:
                    ImplementPhoneBook();
                    break;
                case 6:
                    CreateStopWatch();
                    break;
                case 7:
                    GenerateMarksheet();
                    break;
                case 8:
                    ConvertMeterToKilometer();
                    break;
                case 9:
                    DisplaySquarefeet();
                    break;
                case 10:
                    ConvertInfixToPostfix();
                    break;
                case 11:
                    DemonstrateMultilevelInheritance();
                    break;
                case 12:
                    ImplementDelegates();
                    break;
                case 13:
                    TraverseSinglyLinkedList();
                    break;
                case 14:
                    SortNames();
                    break;
                case 15:
                    FindSmallestElementInMatrix();
                    break;
                case 16:
                    FindLargestElementInMatrix();
                    break;
                case 17:
                    DemonstrateJaggedArrays();
                    break;
                case 18:
                    CalculateDistanceSpeedTime();
                    break;
                case 19:
                    FindSimpleInterest();
                    break;
                case 20:
                    ConvertDigitsToWords();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static void GetDaylightSavingInformation()
        {
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            Console.WriteLine("Daylight saving time information for {0}", localZone.DisplayName);
            Console.WriteLine("   Daylight saving time name: {0}", localZone.DaylightName);
            Console.WriteLine("   Daylight saving time? {0}", localZone.IsDaylightSavingTime(DateTime.Now));
        }

        static void CreateGrayCode()
        {
            Console.WriteLine("Enter the number of bits:");
            int n = int.Parse(Console.ReadLine());
            List<string> grayCodes = GenerateGrayCode(n);
            Console.WriteLine("Gray codes for {0} bits:", n);
            foreach (var code in grayCodes)
            {
                Console.WriteLine(code);
            }
        }

        static List<string> GenerateGrayCode(int n)
        {
            if (n == 0) return new List<string> { "0" };
            if (n == 1) return new List<string> { "0", "1" };

            List<string> prevGray = GenerateGrayCode(n - 1);
            List<string> grayCodes = new List<string>();

            foreach (var code in prevGray)
            {
                grayCodes.Add("0" + code);
            }

            for (int i = prevGray.Count - 1; i >= 0; i--)
            {
                grayCodes.Add("1" + prevGray[i]);
            }

            return grayCodes;
        }

        static void ConvertCelsiusToFahrenheit()
        {
            Console.WriteLine("Enter temperature in Celsius:");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("{0} Celsius is {1} Fahrenheit", celsius, fahrenheit);
        }

        static void GetIPAddress()
        {
            string hostName = Dns.GetHostName();
            IPAddress[] addresses = Dns.GetHostAddresses(hostName);
            foreach (IPAddress address in addresses)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine("IP Address: " + address.ToString());
                }
            }
        }

        static void ImplementPhoneBook()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            while (true)
            {
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Find Contact");
                Console.WriteLine("3. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter phone number:");
                        string number = Console.ReadLine();
                        phoneBook[name] = number;
                        break;
                    case 2:
                        Console.WriteLine("Enter name:");
                        name = Console.ReadLine();
                        if (phoneBook.TryGetValue(name, out number))
                        {
                            Console.WriteLine("Phone number: " + number);
                        }
                        else
                        {
                            Console.WriteLine("Contact not found.");
                        }
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void CreateStopWatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Press 's' to start and 'e' to end the stopwatch.");
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                if (input == 's')
                {
                    stopwatch.Start();
                    Console.WriteLine("Stopwatch started.");
                }
                else if (input == 'e')
                {
                    stopwatch.Stop();
                    Console.WriteLine("Stopwatch stopped. Elapsed time: {0}", stopwatch.Elapsed);
                    break;
                }
            }
        }

        static void GenerateMarksheet()
        {
            Console.WriteLine("Enter student name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter marks for 5 subjects:");
            int[] marks = new int[5];
            for (int i = 0; i < 5; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }

            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            double average = total / 5.0;

            Console.WriteLine("Marksheet for {0}:", name);
            Console.WriteLine("Total Marks: {0}", total);
            Console.WriteLine("Average Marks: {0}", average);
        }

        static void ConvertMeterToKilometer()
        {
            Console.WriteLine("Enter length in meters:");
            double meters = double.Parse(Console.ReadLine());
            double kilometers = meters / 1000;
            Console.WriteLine("{0} meters is {1} kilometers", meters, kilometers);
        }

        static void DisplaySquarefeet()
        {
            Console.WriteLine("Enter the length of the house in feet:");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the house in feet:");
            double width = double.Parse(Console.ReadLine());
            double squareFeet = length * width;
            Console.WriteLine("The house is {0} square feet", squareFeet);
        }

        static void ConvertInfixToPostfix()
        {
            Console.WriteLine("Enter an infix expression:");
            string infix = Console.ReadLine();
            string postfix = InfixToPostfix(infix);
            Console.WriteLine("Postfix expression: " + postfix);
        }

        static string InfixToPostfix(string infix)
        {
            Stack<char> stack = new Stack<char>();
            string postfix = "";
            foreach (char c in infix)
            {
                if (char.IsLetterOrDigit(c))
                {
                    postfix += c;
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfix += stack.Pop();
                    }
                    stack.Pop();
                }
                else
                {
                    while (stack.Count > 0 && GetPrecedence(c) <= GetPrecedence(stack.Peek()))
                    {
                        postfix += stack.Pop();
                    }
                    stack.Push(c);
                }
            }

            while (stack.Count > 0)
            {
                postfix += stack.Pop();
            }

            return postfix;
        }

        static int GetPrecedence(char c)
        {
            switch (c)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return -1;
            }
        }

        static void DemonstrateMultilevelInheritance()
        {
            Grandchild obj = new Grandchild();
            obj.Display();
        }

        class Parent
        {
            public virtual void Display()
            {
                Console.WriteLine("This is the Parent class");
            }
        }

        class Child : Parent
        {
            public override void Display()
            {
                Console.WriteLine("This is the Child class");
            }
        }

        class Grandchild : Child
        {
            public override void Display()
            {
                Console.WriteLine("This is the Grandchild class");
            }
        }

        delegate void SampleDelegate(string message);

        static void ImplementDelegates()
        {
            SampleDelegate del = new SampleDelegate(ShowMessage);
            del("Hello, this is a delegate example.");
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        static void TraverseSinglyLinkedList()
        {
            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);

            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        static void SortNames()
        {
            List<string> names = new List<string> { "John", "Anna", "Zoe", "Mark" };
            names.Sort();
            Console.WriteLine("Sorted names:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void FindSmallestElementInMatrix()
        {
            int[,] matrix = {
                { 3, 8, 1 },
                { 4, 2, 9 },
                { 7, 6, 5 }
            };
            int smallest = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < smallest)
                    {
                        smallest = matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Smallest element in matrix: " + smallest);
        }

        static void FindLargestElementInMatrix()
        {
            int[,] matrix = {
                { 3, 8, 1 },
                { 4, 2, 9 },
                { 7, 6, 5 }
            };
            int largest = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > largest)
                    {
                        largest = matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Largest element in matrix: " + largest);
        }

        static void DemonstrateJaggedArrays()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void CalculateDistanceSpeedTime()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Calculate Distance");
            Console.WriteLine("2. Calculate Speed");
            Console.WriteLine("3. Calculate Time");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter speed (in m/s):");
                    double speed = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter time (in seconds):");
                    double time = double.Parse(Console.ReadLine());
                    double distance = speed * time;
                    Console.WriteLine("Distance: " + distance + " meters");
                    break;
                case 2:
                    Console.WriteLine("Enter distance (in meters):");
                    distance = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter time (in seconds):");
                    time = double.Parse(Console.ReadLine());
                    speed = distance / time;
                    Console.WriteLine("Speed: " + speed + " m/s");
                    break;
                case 3:
                    Console.WriteLine("Enter distance (in meters):");
                    distance = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter speed (in m/s):");
                    speed = double.Parse(Console.ReadLine());
                    time = distance / speed;
                    Console.WriteLine("Time: " + time + " seconds");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static void FindSimpleInterest()
        {
            Console.WriteLine("Enter principal amount:");
            double principal = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter rate of interest:");
            double rate = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter time period (in years):");
            double time = double.Parse(Console.ReadLine());
            double interest = (principal * rate * time) / 100;
            Console.WriteLine("Simple Interest: " + interest);
        }

        static void ConvertDigitsToWords()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Number in words: " + NumberToWords(number));
        }

        static string NumberToWords(int number)
        {
            if (number == 0) return "zero";
            if (number < 0) return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "") words += "and ";
                var unitsMap = new[]
                {
                    "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                    "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
                };
                var tensMap = new[]
                {
                    "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
                };

                if (number < 20) words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0) words += "-" + unitsMap[number % 10];
                }
            }
            return words;
        }
    }
}
