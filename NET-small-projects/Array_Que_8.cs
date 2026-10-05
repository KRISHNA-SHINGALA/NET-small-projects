using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    //Write a C# Sharp program to sort array elements in descending order.
    class Array_Que_8
    {
        public static void Main(String[] args)
        {
            int[] a = new int[5];
            int temp;

            Console.WriteLine("Enter 5 elements:");

            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (a[i] < a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            Console.WriteLine("Array in descending order:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}