using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class sum_of_series
    {
        //Write a program to find the sum of the series 5 + 55 + 555 + 5555 + ..n terms.
        
            public static void Main(string[] args)
            {
                int n, i, sum = 0, term = 0;
                Console.Write("Input the number of terms : ");

                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input number : ");

                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write(num);

                for (i = 1; i <= n; i++)
                {
                    term = term * 10 + num;
                    sum += term;
                    if (i < n)
                    {
                        Console.Write(" + " + term);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("The Sum is : " + sum);
            }
    }
}
