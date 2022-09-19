using System;
using Task_1_VotingSystem_.UI;

namespace Task_1_VotingSystem_
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            string aadhar = Console.ReadLine();
            string pan = Console.ReadLine();
            if (Functions.isvaliduser(aadhar,pan))
            {
                Functions.showCandidateList();
                var choice = int.Parse(Console.ReadLine());
                Functions.incrementVote(choice);
                Functions.updateCandidateData(aadhar,pan);
            }
            else
            {
                Console.WriteLine("Please Enter correct details");
                goto start;
            }
            
        }

        
       

    }
}
