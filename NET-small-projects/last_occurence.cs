using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class last_occurence
    {
        public static void Main(String[] args)
        {
            // Find the last occurrence of an element in an array
            int n, element;
            Console.Write("Enter no. of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the element to find last occurrence: ");
            element = Convert.ToInt32(Console.ReadLine());
            int index = -1;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == element)
                {
                    index = i;
                }
            }
            if (index != -1)
                Console.WriteLine("Last occurrence of element " + element + " is at index " + index + ".");
            else
                Console.WriteLine("Element " + element + " not found in the array.");
        }
    }
}
