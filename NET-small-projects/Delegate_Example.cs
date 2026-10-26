
using System;

// Question 3: Create a Calculate delegate that accepts two numbers
// and performs addition, subtraction, multiplication and division.

public delegate double Calculate(double a, double b);

public class Delegate_Example
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        return a / b;
    }

    public static void Main(string[] args)
    {
        double a = 20;
        double b = 5;

        Calculate c;

        c = Add;
        Console.WriteLine("Addition: " + c(a, b));

        c = Subtract;
        Console.WriteLine("Subtraction: " + c(a, b));

        c = Multiply;
        Console.WriteLine("Multiplication: " + c(a, b));

        c = Divide;
        Console.WriteLine("Division: " + c(a, b));
    }
}
