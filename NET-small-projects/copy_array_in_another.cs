using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class copy_array_in_another
    {
        //copy array into another
        //insert , delete array
        public static void Main(String[] args)
        {
            int merge;
            int merge1;

            Console.Write("Enter the number of elements of first array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] b = new int[a];

            Console.WriteLine("Enter elements:");

            for (int i = 0; i < a; i++)
            {
                Console.Write("Enter number: ");
                b[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            // take second array
            Console.Write("Enter the number of elements of second array: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] y = new int[x];

            Console.WriteLine("Enter elements:");

            for (int i = 0; i < x; i++)
            {
                Console.Write("Enter number: ");
                y[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            //Put array b in to array

            Console.WriteLine("Copy your first array into second array: ");
            for (int i = 0;i < x; i++)
            {
                merge = b[i];
                merge1 = y[i];
                Console.Write(merge + "," + merge1 + ",");
            }
            Console.WriteLine();
        }
    }
}
