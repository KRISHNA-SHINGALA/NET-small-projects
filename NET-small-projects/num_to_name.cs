using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    internal class num_to_name
    {
        public static void NumberToName()
        {
            string number;
            Console.WriteLine("Enter a number:");
            number = Console.ReadLine();

            foreach (char ch in number)
            {
                switch (ch)
                {
                    case '0':
                        Console.Write("Zero");
                        break;
                    case '1':
                        Console.Write("One");
                        break;
                    case '2':
                        Console.Write("Two");
                        break;
                    case '3':
                        Console.Write("Three");
                        break;
                    case '4':
                        Console.Write("Four");
                        break;
                    case '5':
                        Console.Write("Five");
                        break;
                    case '6':
                        Console.Write("Six");
                        break;
                    case '7':
                        Console.Write("Seven");
                        break;
                    case '8':
                        Console.Write("Eight");
                        break;
                    case '9':
                        Console.Write("Nine");
                        break;
                }
            }
        }
    }
}
