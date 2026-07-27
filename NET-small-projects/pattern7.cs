using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    //1
    //2 3
    //4 5 6
    //7 8 9 10
    internal class pattern7
    {
        public static void Main(String[] args)
        {
            int num = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }

                Console.WriteLine();
            }
        }
    }
}
