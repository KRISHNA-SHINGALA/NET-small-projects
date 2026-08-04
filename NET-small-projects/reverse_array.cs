using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class reverse_array
    {
        //take input, Output: reverse of this array
        public static void main(String[] args)
        {
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            Console.WriteLine("Enter elements:");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Reverse the array

            int[] reversedArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                reversedArray[i] = a[n - 1 - i];
            }

            // Output the reversed array

            Console.WriteLine("Reversed array:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(reversedArray[i] + " ");
            }
        }
    }
}
