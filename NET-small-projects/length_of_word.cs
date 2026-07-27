using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class length_of_word
    {
        public static void main(String[] args)
        {
            //take input from user
            Console.WriteLine("Enter string to find length: ");
            string str = Console.ReadLine();

            int length = 0;

            foreach (char c in str)
            {
                //length++;
                length = length + 1;
            }

            // print the rev string
            Console.WriteLine("Length of string is: " + length);
        }
    }
}
