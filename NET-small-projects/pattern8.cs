using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class pattern8
    {
        //    *
        //   ***
        //  *****
        // *******
        //*********
        // *******
        //  *****
        //   ***
        //    *
        public static void Main(string[] args)
        {
            int i, j, k;
            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (i = 4; i >= 1; i--)
            {
                for (j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
