using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class array
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5];
            int sum = 0;
            // task 1 - input five elements into this array
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter no.: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            //task 2 - print array elements
            //task 3 - find and print the sum of all elements in the array
            Console.Write("Array elements are: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
                sum = sum + a[i];
            }
            Console.WriteLine();

            // for sum
            Console.Write("Sum of array elements is: " + sum);
            Console.WriteLine();

            //for average
            int average = sum / a.Length;
            Console.Write("Average of array elements is: " + average);

            Console.WriteLine();

            // find min and max number in the array
            int max = a[0]; // Assume first element is the maximum
            int min = a[0]; // Assume first element is the minimum
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }

                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            Console.WriteLine("Maximum number is: " + max);
            Console.WriteLine("Minimum number is: " + min);
        }
    }
}
