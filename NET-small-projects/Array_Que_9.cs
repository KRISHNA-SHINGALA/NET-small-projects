using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    class Array_Que_9
    {
        public static void Main(String[] args)
        {
            int[] a = new int[5];

            Console.WriteLine("Enter 5 elements:");

            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter position to delete: ");
            int pos = Convert.ToInt32(Console.ReadLine());

            for (int i = pos - 1; i < 4; i++)
            {
                a[i] = a[i + 1];
            }

            Console.WriteLine("Array after deletion:");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}