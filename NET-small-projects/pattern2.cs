using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class pattern2
    {
        // *
        // **
        // ***
        // ****
        // ***** :output
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++) //for rows
            {
                for (int j = 1; j <= i; j++) // for columns
                {
                    Console.Write("* ");
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}
