using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    class Employee_123 // blue print or an templete
    {
        // data members
        public string Name { get; set; }
        private int age;
        public string Dept { get; set; }

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

            //Console.WriteLine(e1.name);
            //Console.WriteLine(e1.age);
            //Console.WriteLine(e1.dept);

            Employee_123 e2 = new Employee_123();
            e2.Name = "Dinesh";
            e2.Age = 32;
            e2.Dept = "IT";

            //Console.WriteLine (e2.name);
            //Console.WriteLine(e2.age);
            //Console.WriteLine(e2.dept);

        }
    }
}
