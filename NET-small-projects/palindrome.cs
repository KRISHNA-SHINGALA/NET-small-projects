using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class palindrome
    {
        public static void main(String[] args)
        {
            //user input
            Console.WriteLine("Enter number for check palindrome :");
            string str = Console.ReadLine();

            int length = 0;
            string rev = "";

            foreach (char c in str)
            {
                rev = c + rev;
            }

            // print the rev string
            Console.WriteLine("Reverse string is: " + rev);
            Console.WriteLine();

            //now check the palindrome or not
            if (rev == str)
            {
                Console.WriteLine("Name is palindrome");
            }
            else
            {
                Console.WriteLine("Name is not palindrome");
            }

        }
    }
}
