using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    class Array_Que_6
    {
        public static void Main(String[] args)
        {
            int[] a = new int[5];

            Console.WriteLine("Enter 5 elements:");

            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = a[0];
            int min = a[0];

            for (int i = 1; i < 5; i++)
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

            Console.WriteLine("Maximum element = " + max);
            Console.WriteLine("Minimum element = " + min);
        }
    }
}