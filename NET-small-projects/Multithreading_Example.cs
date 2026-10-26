
using System;
using System.Threading;

// Question 13: Create multiple threads to display numbers,
// alphabets and a message.

public class Multithreading_Example
{
    public static void DisplayNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Number: " + i);
            Thread.Sleep(100);
        }
    }

    public static void DisplayAlphabets()
    {
        for (char ch = 'A'; ch <= 'J'; ch++)
        {
            Console.WriteLine("Alphabet: " + ch);
            Thread.Sleep(100);
        }
    }

    public static void DisplayMessage()
    {
        Console.WriteLine("Welcome to Multithreading!");
    }

    public static void Main(string[] args)
    {
        Thread t1 = new Thread(DisplayNumbers);
        Thread t2 = new Thread(DisplayAlphabets);
        Thread t3 = new Thread(DisplayMessage);

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("All threads completed.");
    }
}
