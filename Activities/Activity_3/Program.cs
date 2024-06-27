using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Activity_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Sort a list of names");
            Console.WriteLine("2. Demonstrate pass by value");
            Console.WriteLine("3. Demonstrate pass by reference");
            Console.WriteLine("4. Illustrate regular expression patterns");
            Console.WriteLine("5. Implement namespaces");
            Console.WriteLine("6. Demonstrate value type vs reference type");
            Console.WriteLine("7. Demonstrate the goto statement");
            Console.WriteLine("8. Convert upper case to lower case");
            Console.WriteLine("9. Convert characters of a string to opposite case");
            Console.WriteLine("10. Find the length of a string");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SortNames();
                    break;
                case 2:
                    PassByValue();
                    break;
                case 3:
                    PassByReference();
                    break;
                case 4:
                    RegularExpressions();
                    break;
                case 5:
                    ImplementNamespaces();
                    break;
                case 6:
                    ValueTypeVsReferenceType();
                    break;
                case 7:
                    DemonstrateGoto();
                    break;
                case 8:
                    ConvertUpperToLower();
                    break;
                case 9:
                    ConvertToOppositeCase();
                    break;
                case 10:
                    FindStringLength();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static void SortNames()
        {
            List<string> names = new List<string> { "John", "Anna", "Zara", "Mark", "Sophia" };
            names.Sort();

            Console.WriteLine("Sorted list of names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void PassByValue()
        {
            int num = 10;
            ModifyValue(num);
            Console.WriteLine("Value after method call: " + num); // Output: 10
        }

        static void ModifyValue(int x)
        {
            x = x * 2;
        }

        static void PassByReference()
        {
            int num = 10;
            ModifyReference(ref num);
            Console.WriteLine("Value after method call: " + num); // Output: 20
        }

        static void ModifyReference(ref int x)
        {
            x = x * 2;
        }

        static void RegularExpressions()
        {
            string pattern = @"\d+"; // Matches one or more digits
            string input = "The price is 123 dollars.";

            Match match = Regex.Match(input, pattern);
            while (match.Success)
            {
                Console.WriteLine("Found match: " + match.Value);
                match = match.NextMatch();
            }
        }

        static void ImplementNamespaces()
        {
            MyNamespace.MyClass obj = new MyNamespace.MyClass();
            obj.MyMethod();
        }

        static void ValueTypeVsReferenceType()
        {
            int valueType = 10;
            Console.WriteLine("Before ModifyValue (value type): " + valueType);
            ModifyValue(valueType);
            Console.WriteLine("After ModifyValue (value type): " + valueType);

            MyClass referenceType = new MyClass { Value = 10 };
            Console.WriteLine("Before ModifyReference (reference type): " + referenceType.Value);
            ModifyReference(referenceType);
            Console.WriteLine("After ModifyReference (reference type): " + referenceType.Value);

            MyClass anotherReferenceType = new MyClass { Value = 10 };
            Console.WriteLine("Before ModifyReferenceWithRef (ref keyword): " + anotherReferenceType.Value);
            ModifyReferenceWithRef(ref anotherReferenceType);
            Console.WriteLine("After ModifyReferenceWithRef (ref keyword): " + anotherReferenceType.Value);
        }

        static void ModifyReference(MyClass obj)
        {
            obj.Value = obj.Value * 2;
        }

        static void ModifyReferenceWithRef(ref MyClass obj)
        {
            obj = new MyClass { Value = 5 };
        }

        static void DemonstrateGoto()
        {
            int counter = 0;

        Start:
            Console.WriteLine("Counter: " + counter);
            counter++;
            if (counter < 5)
            {
                goto Start;
            }
        }

        static void ConvertUpperToLower()
        {
            Console.WriteLine("Enter a string in upper case:");
            string input = Console.ReadLine();
            string lowerCase = input.ToLower();
            Console.WriteLine("Converted to lower case: " + lowerCase);
        }

        static void ConvertToOppositeCase()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            char[] converted = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    converted[i] = char.ToLower(input[i]);
                }
                else if (char.IsLower(input[i]))
                {
                    converted[i] = char.ToUpper(input[i]);
                }
                else
                {
                    converted[i] = input[i];
                }
            }
            Console.WriteLine("Converted string: " + new string(converted));
        }

        static void FindStringLength()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            Console.WriteLine("Length of the string: " + input.Length);
        }
    }

    class MyClass
    {
        public int Value { get; set; }
    }

    namespace MyNamespace
    {
        class MyClass
        {
            public void MyMethod()
            {
                Console.WriteLine("Hello from MyNamespace.MyClass!");
            }
        }
    }
}
