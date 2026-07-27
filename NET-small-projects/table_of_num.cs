using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class table_of_num
    {
        public static void main(string[] args)
        {
            int number, i, result;
            Console.WriteLine("Enter a number for table:");

            number = Convert.ToInt32(Console.ReadLine());

            i = 1;

            while (i <= 10)
            {
                result = number * i;
                Console.WriteLine(number + " * " + i + " = " + result);
                i++;
            }
            Console.Read();
        }
    }
}
