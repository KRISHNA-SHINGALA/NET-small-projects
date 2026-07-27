using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class simple_calculator
    {
        public static void Sum()
        {
            
            Console.WriteLine("Choose any one operation: (+, -, *, /)");
            string op = Console.ReadLine();

            Console.WriteLine("Enter Number 1");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 3");
            int c = Convert.ToInt32(Console.ReadLine());

            if (op == "+")
            {
                int ans = a + b + c;
                Console.WriteLine("The sum of numbers is: " + ans);
            }
            else if (op == "-")
            {
                int ans = a - b - c;
                Console.WriteLine("The Subtraction of numbers is: " + ans);
            }
            else if (op == "*")
            {
                int ans = a * b * c;
                Console.WriteLine("The Multiplication of numbers is: " + ans);
            }
            else if (op == "/")
            {
                int ans = a / b / c;
                Console.WriteLine("The Division of numbers is: " + ans);
            }
            else
            {
                Console.WriteLine("Wrong option selected!");
            }

            Console.ReadLine();
        }
    }
}
