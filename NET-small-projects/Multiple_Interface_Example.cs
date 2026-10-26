
using System;

// Question 2: Define IPersonalDetails and IProfessionalDetails.
// Implement both interfaces in the Employee class.

public interface IPersonalDetails
{
    void DisplayPersonalDetails();
}

public interface IProfessionalDetails
{
    void DisplayProfessionalDetails();
}

public class Employee1 : IPersonalDetails, IProfessionalDetails
{
    public void DisplayPersonalDetails()
    {
        Console.WriteLine("Name: Rahul");
        Console.WriteLine("Age: 22");
    }

    public void DisplayProfessionalDetails()
    {
        Console.WriteLine("Employee ID: 101");
        Console.WriteLine("Department: IT");
        Console.WriteLine("Salary: 25000");
    }
}

public class Multiple_Interface_Example
{
    public static void Main(string[] args)
    {
        Employee1 emp = new Employee1();

        emp.DisplayPersonalDetails();
        emp.DisplayProfessionalDetails();
    }
}
