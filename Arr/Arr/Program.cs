using System;
using System.Xml;
using System.Collections.Generic;
namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 4, 5, 6, 7 };
            
            // Length:
            Console.WriteLine("Length: "+ numbers.Length);
            
            // IndexOf:
            var index = Array.IndexOf(numbers, 9); // if not found return -1
            Console.WriteLine(index);
            
            // Clear:
            Array.Clear(numbers, 0, 2); // start at pos 0, clear 2 numbers (turn it into 0)
            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }

            // Copy:
            var another = new int[3];
            Array.Copy(numbers,another,3); // copy from one array to another. The last parameter is how many elements we want to copy it to the new array.
            // Sort()
            Array.Sort(numbers);
            // Reverse():
            Array.Reverse(numbers);

            var collections = new List<int>() { 1, 2, 3, 4 };
            collections.Add(1); // The add method can only add one element to the list while the add range is used to add an array to the list
            collections.AddRange(numbers);
            foreach(var num in collections)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine(collections.IndexOf(1));
            Console.WriteLine(collections.LastIndexOf(1));

            Console.WriteLine(collections.Count);
        }
    }   
}