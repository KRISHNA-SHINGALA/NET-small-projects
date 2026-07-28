using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace NET_small_projects
{
    internal class count_occurence
    {
        public static void Main(string[] args)
        {
            // Count occurrences of a given element in an array
            int n, element;
        Console.Write("Enter no. of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i<n; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
    Console.Write("Enter the element to count occurrences: ");
            element = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i<n; i++)
            {
                if (arr[i] == element)
                {
                    count++;
                }
            }
            Console.WriteLine("Element " + element + " occurs " + count + " times in the array.");
        }
    }
}
