using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    class Employee_123 // blue print or an templete
    {
        // data members
        public string name;
        public int age;
        public string dept;

        //method - to work with data member
        public void Display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Dept : " + dept);
        }
    }
    class class_object_tutorial
    {
        public static void main(string[] args)
        {
            Employee_123 e1 = new Employee_123();
            e1.name = "Ramesh";
            e1.age = 25;
            e1.dept = "CSE";

            //Console.WriteLine(e1.name);
            //Console.WriteLine(e1.age);
            //Console.WriteLine(e1.dept);

            Employee_123 e2 = new Employee_123();
            e2.name = "Dinesh";
            e2.age = 32;
            e2.dept = "IT";

            //Console.WriteLine (e2.name);
            //Console.WriteLine(e2.age);
            //Console.WriteLine(e2.dept);

        }
    }
}
