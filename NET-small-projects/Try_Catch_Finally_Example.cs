
using System;

// Question 7: Accept an integer and handle invalid input
// using try-catch-finally blocks.

public class Try_Catch_Finally_Example
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
        }
        finally
        {
            Console.WriteLine("Program execution completed.");
        }
    }
}
