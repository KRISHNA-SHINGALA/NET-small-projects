using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    //Write a program in C# Sharp to separate odd and even integers into separate arrays.
    class Array_Que_7
    {
        public static void Main(String[] args)
        {
            int[] a = new int[5];
            int[] even = new int[5];
            int[] odd = new int[5];

            int e = 0;
            int o = 0;

            Console.WriteLine("Enter 5 elements:");

            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even[e] = a[i];
                    e++;
                }
                else
                {
                    odd[o] = a[i];
                    o++;
                }
            }

            Console.WriteLine("Even elements:");

            for (int i = 0; i < e; i++)
            {
                Console.WriteLine(even[i]);
            }

            Console.WriteLine("Odd elements:");

            for (int i = 0; i < o; i++)
            {
                Console.WriteLine(odd[i]);
            }
        }
    }
}