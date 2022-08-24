using System;

namespace Task_1
{
    class varibles
    {
        public static int rollno;
        public static string sname, sclass;
        public static char ch = 'y';
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            while(varibles.ch == 'y' || varibles.ch == 'Y')
            {
                Console.WriteLine("Enter 1 for Insert Data\nEnter 2 for Print Data\nEnter 3 for Palindrome\nEnter 4 for fibonnaci");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter Roll No : ");
                        varibles.rollno = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Name : ");
                        varibles.sname = Console.ReadLine();
                        Console.WriteLine("Enter Class : ");
                        varibles.sclass = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine(value: "Roll No. : " + varibles.rollno + " Name : " + varibles.sname + " Class : " + varibles.sclass);
                        break;
                    case 3:
                        Console.WriteLine("Enter any number you want to check for palindrome : ");
                        int no = int.Parse(Console.ReadLine());
                        int n = no, rem, sum = 0;
                        while (n > 0)
                        {
                            rem = n % 10;
                            n = n / 10;
                            sum = sum * 10 + rem;
                        }
                        if (no == sum)
                        {
                            Console.WriteLine("Palindrome !!");
                        }
                        else
                        {
                            Console.WriteLine("Not a Palindrome !!");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Enter how may numbers you want to see : ");
                        int numb = int.Parse(Console.ReadLine());
                        int a = 0, b = 1, c;
                        Console.Write("0 1 ");
                        for(int i = 2; i < numb; i++)
                        {
                            c = a + b;
                            Console.Write(c + " ");
                            a = b;
                            b = c;
                        }

                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid number !!!");
                        break;

                }
                Console.WriteLine("Enter y for continue and n for exit ....");
                varibles.ch = char.Parse(Console.ReadLine());
            }
           
        }

    }
}
