
using System;
using System.Threading;

// Question 14: Create a thread, start it, check its state,
// wait using Join(), and display its status at different stages.

public class Thread_Lifecycle_Example
{
    public static void DisplayMessage()
    {
        Console.WriteLine("Thread is running.");

        Thread.Sleep(1000);

        Console.WriteLine("Thread task completed.");
    }

    public static void Main(string[] args)
    {
        Thread t = new Thread(DisplayMessage);

        Console.WriteLine("Before Start: " + t.ThreadState);

        t.Start();

        Console.WriteLine("After Start: " + t.ThreadState);

        t.Join();

        Console.WriteLine("After Join: " + t.ThreadState);
        Console.WriteLine("Main program completed.");
    }
}
