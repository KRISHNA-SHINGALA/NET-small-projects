
using System;
using System.Collections.Generic;
using System.Linq;

// Question 11: Create a collection of integers and use LINQ
// to display all even numbers in ascending order.

public class LINQ_Example
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>()
        {
            15, 8, 2, 11, 6, 20, 3, 4
        };

        var evenNumbers = numbers
            .Where(n => n % 2 == 0)
            .OrderBy(n => n);

        Console.WriteLine("Even numbers in ascending order:");

        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
