
using System;

// Question 5: Create a BankAccount class and raise an event
// whenever money is deposited into the account.

public class BankAccount
{
    public event Action DepositEvent;

    public void Deposit()
    {
        Console.WriteLine("Money deposited successfully!");

        if (DepositEvent != null)
        {
            DepositEvent();
        }
    }
}

public class Event_Example
{
    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        account.DepositEvent += ShowMessage;

        account.Deposit();
    }

    public static void ShowMessage()
    {
        Console.WriteLine("Deposit event occurred.");
    }
}
