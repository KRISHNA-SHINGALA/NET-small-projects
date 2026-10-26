
using System;

// Question 4: Demonstrate a multicast delegate that calls
// multiple methods to display student name, course and semester.

public delegate void StudentInfo();

public class Multicast_Delegate_Example
{
    public static void DisplayName()
    {
        Console.WriteLine("Name: Rahul");
    }

    public static void DisplayCourse()
    {
        Console.WriteLine("Course: B.Tech Computer Engineering");
    }

    public static void DisplaySemester()
    {
        Console.WriteLine("Semester: 5");
    }

    public static void Main(string[] args)
    {
        StudentInfo student;

        student = DisplayName;
        student += DisplayCourse;
        student += DisplaySemester;

        student();
    }
}
