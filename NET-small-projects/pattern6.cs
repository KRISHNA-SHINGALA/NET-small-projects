using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class pattern6
    {
        //    *
        //   * *
        //  * * *
        // * * * *
        //* * * * *
        public static void Main(String[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //int rows = 4;
            //for (int i =1; i <= rows; i++)
            //{
            //    for(int j =1; j <= rows; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
        }
    }
}
