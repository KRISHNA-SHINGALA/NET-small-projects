using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    class Employee_123 // blue print or an templete
    {
        // data members
        public string Name { get; set; }
        private int age; // data member
        public string Dept { get; set; }

        private double Salary;

        public void SetSalary(double Salary) //setter method
        {
            this.Salary = Salary;
        }
        public double GetSalary() //getter method
        {
            return this.Salary;
        }

        //prooperty looks like a variable and works like a method
        public int Age //proprty
        {
            get //read only
            {
                return age;
            }
            set //write only
            {
                age = value;
            }
        }

        //method - to work with data member
        public void Display()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Dept : " + Dept);
            Console.WriteLine("Salary : " + Salary);
        }
    }
    class class_object_tutorial
    {
        public static void main(string[] args)
        {
            Employee_123 e1 = new Employee_123();
            e1.Name = "Ramesh";
            e1.Age = 25;
            e1.Dept = "CSE";
            e1.SetSalary(100000);
            e1.Display();

            //Console.WriteLine(e1.name);
            //Console.WriteLine(e1.age);
            //Console.WriteLine(e1.dept);

            Employee_123 e2 = new Employee_123();
            e2.Name = "Dinesh";
            e2.Age = 32;
            e2.Dept = "IT";
            e2.SetSalary(200000);
            e2.Display();

            //Console.WriteLine (e2.name);
            //Console.WriteLine(e2.age);
            //Console.WriteLine(e2.dept);

        }
    }
}
