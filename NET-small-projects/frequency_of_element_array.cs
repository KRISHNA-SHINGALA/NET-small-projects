using System;

namespace NET_small_projects
{
    internal class frequency_of_element_array
    {
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
            Console.Write("Enter number to find frequency: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            // Count frequency
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    count++;
                }
            }

            Console.WriteLine("Frequency of " + num + " is: " + count);
        }
    }
}