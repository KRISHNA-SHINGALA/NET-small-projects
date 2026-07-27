using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class word_to_reword
    {
        //public static void main(String[] args)
        //{
        //    //take input from user
        //    Console.WriteLine("Enter string to reverse: ");
        //    string str = Console.ReadLine();

        //    //one empty string variable(rev) to store the reversed string
        //    string rev = "";

        //    //loop through the string from last index to first
        //    //rev = rev +str[i]
        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        rev = rev + str[i];
        //    }

        //    // print the rev string
        //    Console.WriteLine(rev);
        //    }

        public static void main(String[] args)
        {
            //take input from user
            Console.WriteLine("Enter string to reverse: ");
            string str = Console.ReadLine();

            int length = 0;
            string rev = "";

            foreach (char c in str)
            {
                //length++;
                //length = length + 1;
                rev = c + rev;
            }

            // print the rev string
            Console.WriteLine("Reverse string is: " + rev);
        }
    }
}
