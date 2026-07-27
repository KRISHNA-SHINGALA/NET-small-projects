using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class phone_no_hide
    {
        public static void main(string[] args)
        {
            string str;
            Console.WriteLine("Enter mobile number : ");
            str = Console.ReadLine();
            int n = str.Length;

            for (int i = 0; i < n; i++)
            {
                if (i < n / 2)
                {
                    Console.Write(str[i]);
                }
                else
                {
                    Console.Write("X");
                }
            }
        }
    }
}
