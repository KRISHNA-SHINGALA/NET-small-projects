using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class merge_arry
    {
        //copy array into another
        public static void Main(String[] args)
        {
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

            //Put array b in to array y

            Console.WriteLine("Your merge array is: ");
            for (int i = 0; i < x; i++)
            {
                Console.Write(b[i] + "," + y[i] + ",");
            }
        }
    }
}
