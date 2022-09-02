using System;
using System.Collections.Generic;


namespace Task_1
{
    class person
    {
        public int age;
    }
    class Program
    {
        static void square(person a,person b)
        {
            a.age = a.age * a.age;
            b.age = b.age * b.age;
            Console.WriteLine(a.age + " " + b.age);
        }
        static void Main(string[] args)
        {
            person p1 = new person();
            person p2 = new person();
            p1.age = 5;
            p2.age = 10;
            Console.WriteLine(p1.age + " " + p2.age);
            square(p1, p2); // reference type
            Console.WriteLine(p1.age + " " + p2.age);

            Object obj = new Object();
            int i = 10;

            Type t1 = obj.GetType();
            Type t2 = i.GetType();

            Console.WriteLine(t1.BaseType);
            Console.WriteLine(t1.Name);
            Console.WriteLine(t1.FullName);
            Console.WriteLine(t1.Namespace);
            Console.WriteLine("");

        /*
            Console.WriteLine(t2.BaseType);
            Console.WriteLine(t2.Name);
            Console.WriteLine(t2.FullName);
            Console.WriteLine(t2.Namespace);
            Console.WriteLine("");
            //int a = int.Parse(Console.ReadLine());

            string ch = "mohit";
            Type t4 = ch.GetType();
            Console.WriteLine(t4.BaseType);
            Console.WriteLine(t4.Name);
            Console.WriteLine(t4.FullName);
            Console.WriteLine(t4.Namespace);
            Console.WriteLine("");

            List<string> ob = new List<string>();
            Type t3 = ob.GetType();
            Console.WriteLine(t3.BaseType);
            Console.WriteLine(t3.Name);
            Console.WriteLine(t3.FullName);
            Console.WriteLine(t3.Namespace);
        */

            OPOverloading.Class1 num1 = new OPOverloading.Class1(0);
            OPOverloading.Class1 num2 = new OPOverloading.Class1(0);
            OPOverloading.Class1 num3 = new OPOverloading.Class1(0);

            Console.Write("Enter First number : ");
            num1.no = int.Parse(Console.ReadLine());
            Console.Write("Enter Second number : ");
            num2.no = int.Parse(Console.ReadLine());

            num3 = num2 + num1;
            Console.WriteLine("Falsy Sum of {0} and {1} is : {2}", num1.no, num2.no, num3.no);

        }
    }
}
