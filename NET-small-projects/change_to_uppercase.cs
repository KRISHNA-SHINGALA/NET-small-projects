using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class change_to_uppercase
    {
        public static void main(string[] args)
        {
            string str, result;
            Console.WriteLine("Enter a string : ");
            str = Console.ReadLine();

            result = str.ToUpper();
            Console.WriteLine(result);
        }
    }
}
