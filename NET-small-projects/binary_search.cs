using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class binary_search
    {
        public static void main(String[] args)
        {
            //finad array of element of using binary search
            // Input from user
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            Console.WriteLine("Enter elements in ascending order:");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Number to search
            Console.Write("Enter number to search: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int first = 0;
            int last = n - 1;
            bool found = false;

            // Binary Search
            while (first <= last)
            {
                int mid = (first + last) / 2;

                if (a[mid] == num)
                {
                    found = true;
                    break;
                }
                else if (num < a[mid])
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }
            }

            if (found)
            {
                Console.WriteLine("Number found in the array.");
            }
            else
            {
                Console.WriteLine("Number not found in the array.");
            }
        }
    }
}
