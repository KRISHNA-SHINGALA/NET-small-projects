using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    class Array_Que_4
    {
        public static void Main(String[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];

            Console.WriteLine("Enter 5 elements:");

            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                b[i] = a[i];
            }

            Console.WriteLine("Elements of second array:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}