using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    class Array_Que_5
    {
        public static void Main(String[] args)
        {
            int[] a = new int[5];
            int count = 0;

            Console.WriteLine("Enter 5 elements:");

            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("Number of duplicate elements = " + count);
        }
    }
}