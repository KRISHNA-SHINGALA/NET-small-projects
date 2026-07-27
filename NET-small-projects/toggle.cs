using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class toggle
    {
        public static void main(string[] args)
        {
            string str;
            Console.WriteLine("Enter a string for toggle case : ");
            str = Console.ReadLine();

            string result = "";
            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    result += char.ToLower(ch);

                }
                else
                {
                    result += char.ToUpper(ch);
                }
            }
            Console.WriteLine(result);
        }
    }
}
