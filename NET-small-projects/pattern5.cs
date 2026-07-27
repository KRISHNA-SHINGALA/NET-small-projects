using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class pattern5
    {
        // 1
        // 2 3
        // 4 5 6
        // 7 8 9 10
        // 11 12 13 14 15 :output
        public static void Main(string[] args)
        {
            int k = 1;
            for (int i = 1; i <= 5; i++) //for rows
            {
                for (int j = 1; j <= i; j++) // for columns
                {
                    Console.Write(k);
                    k = k + 1;

                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}
