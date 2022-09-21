using System;
using System.Threading;
using Task_1_VotingSystem_.Domain.Interface;

namespace Task_1_VotingSystem_.UI
{
    class Functions : IUI, IGreet, IAnimation
    {

        public  void showCandidateList()
        {
            Console.Clear();
            Console.WriteLine("\t-------------------------------------------------\t");
            Console.WriteLine("\t|\tPress\t\t\t\t\t|\t");
            Console.WriteLine("\t|\t1 for A\t\t\t\t\t|\t");
            Console.WriteLine("\t|\t2 for B\t\t\t\t\t|\t");
            Console.WriteLine("\t|\t3 for C\t\t\t\t\t|\t");
            Console.WriteLine("\t|\t4 for D\t\t\t\t\t|\t");
            Console.WriteLine("\t|\t5 for E\t\t\t\t\t|\t");
            Console.WriteLine("\t-------------------------------------------------\t");
        }

        public void Waiting()
        {
            Console.Write("Please Wait...");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
        }

        public void GreetUser()
        {
            Console.Clear();
            Console.WriteLine("Thanks for Voting");
        }  
    }
}
