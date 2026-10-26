
using System;

// Question 1: Define an interface IEmployee with methods to
// accept and display employee details. Implement it using Employee.

public interface IEmployee
{
    void AcceptDetails();
    void DisplayDetails();
}

public class Employee : IEmployee
{
    int id;
    string name;

    public void AcceptDetails()
    {
        Console.Write("Enter Employee ID: ");
        id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        name = Console.ReadLine();
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\nEmployee Details");
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);
    }
}

public class Interface_Example
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee();

        emp.AcceptDetails();
        emp.DisplayDetails();
    }
}
