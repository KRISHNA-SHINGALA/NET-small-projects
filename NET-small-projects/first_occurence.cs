using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class first_occurence
    {
        //count occurence of a given number in an array
        public static void Main(string[] args)
        {
            //input from user

            int n;

            Console.Write("Enter the no. of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter no.: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Number to search

            Console.Write("Enter number to find first occurence: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Perform linear search

            bool found = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    found = true;
                    Console.WriteLine("First occurence of " + num + " is at index: " + i);
                    break;
                }
            }

            if (found == false)
            {
                Console.WriteLine("Number not found in the array.");
            }
        }
    }
}
