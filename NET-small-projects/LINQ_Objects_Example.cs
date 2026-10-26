
using System;
using System.Collections.Generic;
using System.Linq;

// Question 12: Create Student objects and use LINQ to display
// students with marks greater than 70, sorted by marks.

public class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
    public int Marks { get; set; }
}

public class LINQ_Objects_Example
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student
            {
                StudentID = 1,
                Name = "Rahul",
                Course = "B.Tech",
                Marks = 85
            },

            new Student
            {
                StudentID = 2,
                Name = "Priya",
                Course = "BCA",
                Marks = 65
            },

            new Student
            {
                StudentID = 3,
                Name = "Amit",
                Course = "B.Tech",
                Marks = 90
            },

            new Student
            {
                StudentID = 4,
                Name = "Neha",
                Course = "BCA",
                Marks = 75
            }
        };

        var result = students
            .Where(s => s.Marks > 70)
            .OrderBy(s => s.Marks);

        Console.WriteLine("Students with marks greater than 70:");

        foreach (Student s in result)
        {
            Console.WriteLine(
                s.StudentID + " " +
                s.Name + " " +
                s.Course + " " +
                s.Marks
            );
        }
    }
}
