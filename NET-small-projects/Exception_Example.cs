
using System;

// Question 6: Accept two numbers and perform division.
// Handle DivideByZeroException using try-catch.

public class Exception_Example
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a / b;

            Console.WriteLine("Division: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
    }
}
