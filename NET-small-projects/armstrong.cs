using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class armstrong
    {
        public static void Armstrong()
        {
            int num, original, remainder, result = 0;
            Console.WriteLine("Enter number to calculate armstrong number:");
            num = Convert.ToInt32(Console.ReadLine());

            original = num;
            while (num > 0)
            {
                remainder = num % 10;
                result = result + (remainder * remainder * remainder);
                //result += (int)Math.Pow(num, num);
                num = num / 10;
            }

            if (original == result)
            {
                Console.WriteLine("This is an Armstrong number.");
            }
            else
            {
                Console.WriteLine("This is not an Armstrong number.");
            }
            Console.ReadLine();
        }
    }
}
