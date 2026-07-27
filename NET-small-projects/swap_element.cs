using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    class number
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

    }

    class swap_element
    {
        public static void Main(string[] args)
        {
            number n = new number();
            int x = 50; int y = 100;

            Console.WriteLine("Before swapping x is: " + x);
            Console.WriteLine("Before swapping y is: " + y);

            n.swap(ref x, ref y);

            Console.WriteLine("After swapping x is: " + x);
            Console.WriteLine("After swapping y is: " + y);
        }
    }
}
