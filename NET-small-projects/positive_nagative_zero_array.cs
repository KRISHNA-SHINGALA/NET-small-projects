using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class positive_nagative_zero_array
    {
        //count positive, negative and zero numbers from array
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

            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    positiveCount++;
                }
                else if (a[i] < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            Console.WriteLine("\n--- Output ---");
            Console.WriteLine("Total Positive numbers: " + positiveCount);
            Console.WriteLine("Total Negative numbers: " + negativeCount);
            Console.WriteLine("Total Zero numbers: " + zeroCount);
            Console.ReadLine();
        }
    }
}
