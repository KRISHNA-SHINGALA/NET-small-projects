
using System;
using System.Collections.Generic;

// Question 10: Create a list of student marks and use a lambda
// expression to display marks greater than 50.

public class Lambda_Collection_Example
{
    public static void Main(string[] args)
    {
        List<int> marks = new List<int>()
        {
            45, 75, 60, 35, 90, 50, 82
        };

        Console.WriteLine("Marks greater than 50:");

        marks.FindAll(m => m > 50)
             .ForEach(m => Console.WriteLine(m));
    }
}
