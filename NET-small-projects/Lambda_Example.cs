
using System;

// Question 9: Use lambda expressions to calculate addition,
// multiplication and maximum of two numbers.

public class Lambda_Example
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Func<int, int, int> add = (x, y) => x + y;
        Func<int, int, int> multiply = (x, y) => x * y;
        Func<int, int, int> maximum = (x, y) => x > y ? x : y;

        Console.WriteLine("Addition: " + add(a, b));
        Console.WriteLine("Multiplication: " + multiply(a, b));
        Console.WriteLine("Maximum: " + maximum(a, b));
    }
}
