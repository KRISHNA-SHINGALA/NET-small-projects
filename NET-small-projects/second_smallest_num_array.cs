using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class second_smallest_num_array
    {
        //find the second smallest number in the array
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the no. of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter no.: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int S = int.MaxValue;
            int SS = int.MaxValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < S)
                {
                    SS = S;
                    S = a[i];
                }
                else if (a[i] < SS && a[i] != S)
                {
                    SS = a[i];
                }
            }

            if (SS == int.MaxValue)
            {
                Console.WriteLine("There is no second smallest number in the array.");
            }
            else
            {
                Console.WriteLine("The second smallest number in the array is: " + SS);
            }
            Console.ReadLine();
        }
    }
}
