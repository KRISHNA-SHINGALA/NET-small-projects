using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    //Write a C# Sharp program to read n values in an array and display them in reverse order.
    class Array_Que_3
    {
        public static void Main(String[] args)
        {
            int n;

            Console.Write("Enter size of array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            Console.WriteLine("Enter elements:");

            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array in reverse order:");

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}