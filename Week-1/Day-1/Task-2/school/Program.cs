using System;


namespace school
{
    class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            teacher tch = new teacher();

            Console.Write("Enter 1 for Insert Details of Student\n      2 for Insert Details of Teacher\n");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter Roll No. : ");
                    std.roll = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Name : ");
                    std.name = Console.ReadLine();
                    std.show();
                    break;
                case 2:
                    Console.WriteLine("Enter ID : ");
                    tch.ID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Name : ");
                    tch.name = Console.ReadLine();
                    tch.show();
                    break;
                default:
                    Console.WriteLine("Enter a valid option !!!!");
                    break;
            }
        }
    }
}
