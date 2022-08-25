using System;

namespace Task_2
{
    public class account
    {
        public int accno;
        public string name;
        public static float roi = 8.8f;

        public account(int accno,string name)
        {
            this.accno = accno;
            this.name = name;
            roi = 10.5f;
        }

        public void display()
        {
            Console.WriteLine(accno + " " + name + " " + roi);
        }
    }
    public static class myMath
    {
        public static float pi = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }
    }

    public struct employee
    {
        public int id;
        public string name;
        public double salary;
        public string gender;
    };
    class Program
    {
        static void Main(string[] args)
        {
            account a1 = new account(10256, "Sanya");
            account a2 = new account(10257, "Tanya");

            a1.display();
            a2.display();

            //Static Class
            //myMath ob = new myMath();
            int n = 8;
            Console.WriteLine("Pi value is : " + myMath.pi);
            Console.WriteLine("cube of " + n + " is : " + myMath.cube(n));


            //structure
            employee emp;
            Console.WriteLine("Enter the Employee ID :");
            emp.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name :");
            emp.name = Console.ReadLine();
            Console.WriteLine("Enter the Employee Salary : ");
            emp.salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employee Gender : ");
            emp.gender = Console.ReadLine();

            Console.WriteLine(emp.id + " " + emp.name + " " + emp.gender + " " + emp.salary);
        }
    }
}
