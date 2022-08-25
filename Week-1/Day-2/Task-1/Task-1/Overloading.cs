using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    public class Overloading
    {
        public void sum()
        {
            Console.WriteLine("Enter any number");
        }
        public void sum(int a)
        {
            Console.WriteLine("Enter two numbers");
        }
        public void sum(int a, int b)
        {
            Console.WriteLine("Sum is : "+(a+b));
        }
        public void sum(int a, int b,int c)
        {
            Console.WriteLine("Sum is : " + (a + b + c));
        }

    }
}
