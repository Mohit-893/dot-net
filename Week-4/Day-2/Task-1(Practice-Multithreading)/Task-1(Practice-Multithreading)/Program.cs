using System;
using System.Threading;

namespace Task_1_Practice_Multithreading_
{
    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public void Print()
        {
            Console.WriteLine($"Id = {Id}");
            Console.WriteLine($"Name = {Name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread currentThread = Thread.CurrentThread;

            //Get name of Thread
            Console.WriteLine($"Thread: {currentThread.Name}");

            currentThread.Name = "Main";
            Console.WriteLine($"Thread name: {currentThread.Name}");
            Console.WriteLine($"Thread Id: {currentThread.ManagedThreadId}");
            Console.WriteLine($"Thread is Alive? : {currentThread.IsAlive}");
            Console.WriteLine($"Priority of Thread: {currentThread.Priority}");
            Console.WriteLine($"Status of Thread: {currentThread.ThreadState}");
            Console.WriteLine($"IsBackground: {currentThread.IsBackground}");

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);      // here, we have delay execution by 1000 milliseconds
                Console.WriteLine(i);
            }
            Thread Thread1 = new Thread(Print);
            Thread Thread2 = new Thread(new ThreadStart(Print));
            Thread Thread3 = new Thread(() => Console.WriteLine("Hello from thread3"));

            Thread1.Start();  // Thread1 starts
            Thread2.Start();  // Thread1 starts
            Thread3.Start();  // Thread1 starts

            void Print()
            {
                Console.WriteLine("Threads");
            }






            Thread MainThread = new Thread(Print2);
            // Run thread
            MainThread.Start();

            // Actions that we make in the Main Thread
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main Thread: {i}");
                //Pause thread
                Thread.Sleep(300);
            }

            // Actions from second thread
            void Print2()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Second Thread: {i}");
                    Thread.Sleep(1000);
                }
            }






            Student student = new Student() { Id = 1, Name = "John" };

            Thread myThread = new Thread(student.Print);
            myThread.Start();

            


        }
    }
}
