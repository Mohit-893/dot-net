using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

            // Armstrong

            Console.WriteLine("Enter any number you want to check for : ");
            int n = int.Parse(Console.ReadLine());
            int num = n, r, s = 0;
            for (; n != 0;)
            {
                r = n % 10;
                n = n / 10;
                s = s + (r * r * r);
            }
            if (num == s)
            {
                Console.WriteLine("ArmStrong ");
            }
            else
            {
                Console.WriteLine("Not Armstrong !!!");
            }

            //Overloading

            Overloading od = new Overloading();
            od.sum();
            od.sum(1);
            od.sum(2, 3);
            od.sum(5, 10, 15);

        }
    }
}
