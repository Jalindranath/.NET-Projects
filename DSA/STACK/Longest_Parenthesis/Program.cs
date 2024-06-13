using System;
using System.Collections.Generic;

namespace Longest_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Parenthesis string:");
            string str = Console.ReadLine();

            if (string.IsNullOrEmpty(str) || str.Length < 2)
            {
                Console.WriteLine("String is not entered or contains less than two characters.");
                return;
            }

            Stack<int> s = new Stack<int>();
            s.Push(-1);  // Initialize the stack with -1 to handle the base case

            int maxLen = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    s.Push(i);
                }
                else
                {
                    s.Pop();
                    if (s.Count == 0)
                    {
                        s.Push(i);
                    }
                    else
                    {
                        maxLen = Math.Max(maxLen, i - s.Peek());
                    }
                }
            }

            Console.WriteLine($"The length of the longest valid parentheses substring is: {maxLen}");
            Console.ReadLine();
        }
    }
}
