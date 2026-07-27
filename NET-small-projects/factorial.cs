using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class factorial
    {
        public static void Main(string[] args)
        {
            // Factorial of a number
            int number, i, fact = 1;
            Console.WriteLine("Enter a input first fact number ");

            // Read the input from the user and convert it to an integer
            number = Convert.ToInt32(Console.ReadLine());

            // Calculate the factorial using a for loop
            for (i = 1; i <= number; i++)
            {
                // Multiply the current value of fact by i
                fact = fact * i;
            }

            // Print the result to the console
            Console.WriteLine("Factorial of " + number + ":" + fact);
            Console.Read();

        }
    }
}
