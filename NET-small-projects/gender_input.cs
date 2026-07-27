using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class gender_input
    {
        public static void Gender()
        {
            string name;
            char gender;

            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter your gender (M/F):");
            gender = Convert.ToChar(Console.ReadLine());

            if (gender == 'M' || gender == 'm')
            {
                Console.WriteLine("Hello Mr. " + name);
            }
            else if (gender == 'F' || gender == 'f')
            {
                Console.WriteLine("Hello Ms. " + name);

            }
            else
            {
                Console.WriteLine("Invalid gender");
            }
            Console.ReadLine();
        }
    }
}
