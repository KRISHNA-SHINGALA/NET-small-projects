using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class fibonacci
    {
        public static void main(string[] args)
        {
            int n1 = 0, n2 = 1, n3;
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i <= 10; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }
    }
}
