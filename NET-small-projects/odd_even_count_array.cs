using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class odd_even_count_array
    {
        // count odd even numbers from array
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the no. of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter no.: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine("\n--- Output ---");
            Console.WriteLine("Total Even numbers: " + evenCount);
            Console.WriteLine("Total Odd numbers: " + oddCount);

            Console.ReadLine();
        }
    }
}
