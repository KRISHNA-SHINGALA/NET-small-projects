using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class pattern3
    {
        // 1
        // 12
        // 123
        // 1234
        // 12345 :output
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++) //for rows
            {
                for (int j = 1; j <= i; j++) // for columns
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}
