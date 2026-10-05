using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NET_small_projects
{
    //Write a program of sorting an array.Declare single dimensional array and accept 5 integer values from the user.Then sort the input in ascending order and display output.
    class Array_Que_2
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
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            Console.WriteLine("Array in ascending order:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}