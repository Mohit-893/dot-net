using System;
using Studentdata;
using Teacherdata;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Student Details\n      2 for Teacher details");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Student sd = new Student();
                    Console.WriteLine("Enter Roll no. of Student : ");
                    sd.roll = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Name of Student : ");
                    sd.name = Console.ReadLine();
                    sd.show();
                    break;

                case 2:
                    Teacher td = new Teacher();
                    Console.WriteLine("Enter ID of Teacher : ");
                    td.id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Name of Student : ");
                    td.name = Console.ReadLine();
                    td.show();
                    break;

                default:
                    Console.WriteLine("Please Enter a Valid option !!!");
                    break;
            }
        }
    }
}
