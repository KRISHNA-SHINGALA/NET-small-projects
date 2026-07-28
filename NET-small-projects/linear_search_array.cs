using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace NET_small_projects
{
    internal class linear_search_array
    {
        //perform linear search on an array
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

            Console.Write("Enter number to search: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Perform linear search

            bool found = false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    found = true;
                    break;
                }
            }

            if (found == true)
            {
                Console.WriteLine("Number found in the array.");

            }
            else
            {
                Console.WriteLine("Number not found in the array.");

            }
        }
    }
}
