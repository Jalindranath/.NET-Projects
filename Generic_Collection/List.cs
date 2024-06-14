using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    /*
     * Add(T item): Adds an object to the end of the List<T>.
     * Remove(T item): Removes the first occurrence of a specific object from the List<T>.
     * Count: Gets the number of elements contained in the List<T>.
     * Contains(T item): Determines whether an element is in the List<T>.
     * Insert(int index, T item): Inserts an element into the List<T> at the specified index.
     * RemoveAt(int index): Removes the element at the specified index.
     */
    internal class List
    {
        public static void LinkOperations()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            foreach(int number in numbers)
            {
                Console.Write(number + "  ");
            }
            int first = numbers[0];
            Console.WriteLine("The Number is: "+first);
            numbers.Remove(1);
            foreach (int number in numbers)
            {
                Console.Write(number + "  ");
            }
            Console.WriteLine("The Total Count of Number is: " + numbers.Count() + "\n");
            Console.WriteLine("The list contains: " + numbers.Contains(1) + "\n");
            numbers.Insert(0, 100);
            foreach (int number in numbers)
            {
                Console.Write(number + "  ");
            }
            numbers.RemoveAt(2);
            Console.WriteLine("After removing Index 2 \n");
                foreach (int number in numbers)
            {
                Console.Write(number+"  ");
            }
            




        }
    }
}
