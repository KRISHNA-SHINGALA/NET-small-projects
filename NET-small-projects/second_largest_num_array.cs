using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class second_largest_num_array
    {
        //find the second largest number in the array
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

            int L = int.MinValue;
            int SL = int.MinValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > L)
                {
                    SL = L;
                    L = a[i];
                }
                else if (a[i] > SL && a[i] != L)
                {
                    SL = a[i];
                }
            }

            if (SL == int.MinValue)
            {
                Console.WriteLine("There is no second largest number in the array.");
            }
            else
            {
                Console.WriteLine("The second largest number in the array is: " + SL);
            }
            Console.ReadLine();
        }
    }
}
