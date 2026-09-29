using System;
using System.Collections.Generic;
using System.Text;

namespace NET_small_projects
{
    delegate void MyDelegate(int x, int y);

    //delegate void MyDelegate2(int x, int y);
    internal class DelegateDemo
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public static void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public static void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        //public static void Add2(int x, int y)
        //{
        //    Console.WriteLine(x + y);
        //}
        public static void Main(String[] args)
        {
            //Instation
            MyDelegate obj = new MyDelegate(Add);
            obj += new MyDelegate(Sub);
            obj += Mul;
            obj += Div;

            //Invocation
            obj(15, 5);

            //MyDelegate obj = new MyDelegate(Add2);
            Add(15, 5);
        }
    }
}
