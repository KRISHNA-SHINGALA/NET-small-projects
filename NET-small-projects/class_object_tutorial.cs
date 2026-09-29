using NET_small_projects;
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

            Console.WriteLine();

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

//class RegularEmployee: Employee_123 //level-1
//{
//    //Data members: from this class: 5
//    //Data members: from parent class(Employee): 3

//    //Data members: from this class: 0
//    //Data members: from parent class(Employee): 1

//    //Data members: from this class: 0
//    //Data members: from parent class(Employee): 3

//    private double Basic;
//    private double DA;
//    private double HRA;
//    private double PF;
//    private double PT;

//}

//public new void Check()
//{
//    Console.WriteLine("Check method")
//}

//public new void Test()
//{
//    Console.WriteLine("Test method")
//}

//Employee_123 e3 = new Employee_123();
//e3.Display(); //Employee
//e3.Check(); //Employee
//e3.Test(); //error

//RegularEmployee e4 = new RegularEmployee();
//e4.Display(); //RegularEmployee
//e4.Check(); //REgularEmployee
//e4.Test(); //ok

//Employee_123 e5 = new RegularEmployee();
//e5.Display(); //RegularEmployee
//e5.Check(); //Both? Employee?
//e5.Test(); //error