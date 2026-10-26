
using System;

// Question 8: Create InsufficientBalanceException.
// Raise it when withdrawal amount exceeds available balance.

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message)
        : base(message)
    {
    }
}

public class Custom_Exception_Example
{
    public static void Main(string[] args)
    {
        double balance = 5000;

        try
        {
            Console.WriteLine("Available Balance: " + balance);
            Console.Write("Enter withdrawal amount: ");

            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > balance)
            {
                throw new InsufficientBalanceException(
                    "Insufficient balance!"
                );
            }

            balance = balance - amount;

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining Balance: " + balance);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
