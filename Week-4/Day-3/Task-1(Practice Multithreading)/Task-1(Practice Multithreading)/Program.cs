using System;
using System.Threading;

namespace Task_1_Practice_Multithreading_
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo1();
            PrintInfo2();
            Thread t1 = new Thread(new ThreadStart(PrintInfo1));
            Thread t2 = new Thread(new ThreadStart(PrintInfo2));
            t1.Start();
            t2.Start();
        }
        static void PrintInfo1()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("i value: {0}", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("First method completed");
        }
        static void PrintInfo2()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("i value: {0}", i);
            }
            Console.WriteLine("Second method completed");
        }
    }
}
