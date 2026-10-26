using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    // Abstract base class
    abstract class abstrat1
    {
        public abstract void Display();
    }

    // Derived class 1
    class Employee1 : abstrat1
    {
        public override void Display()
        {
            Console.WriteLine("Employee1");
        }
    }

    // Derived class 2
    class Employee2 : abstrat1
    {
        public override void Display()
        {
            Console.WriteLine("Employee2");
        }
    }

    class Abstract_Concept_demo
    {
        public static void Main(string[] args)
        {
            abstrat1 emp1 = new Employee1();
            emp1.Display();

            abstrat1 emp2 = new Employee2();
            emp2.Display();

            Console.ReadLine();
        }
    }
}
