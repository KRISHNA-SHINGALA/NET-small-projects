using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    class Array_Que_1
    {
        public static void Main(String[] args)
        {
            int[] a = new int[5];

            Console.WriteLine("Enter 5 elements:");

            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array elements are:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
